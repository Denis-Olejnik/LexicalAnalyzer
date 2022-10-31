using LexicalAnalyzer.LexicalAnalyzer.Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    /// <summary>
    /// The class expands the base dictionary. This class stores all base service words.
    /// </summary>
    internal class ServiceWordsDictionary
    {
        /// <summary>
        /// This dictionary contains a list of all service words.
        /// For example: "Condition" : "true", "false"
        /// </summary>
        public readonly Dictionary<string, List<string>> serviceWords = new Dictionary<string, List<string>>()
        {
            {"Condition", new List<string> { "if", "else", } },
            {"Statement", new List<string>{ "true", "false", } },
            {"Logical", new List<string> {"xor", "or", "and", "not", } },
            {"Service", new List<string> {"program", "var", "begin", "write", "writeln", "for", "to", "do", "random", "randomize", "end"} },
            {"Variable type", new List<string> {"integer", } }
        };

        /// <summary>
        /// The method takes a word and compares it against the service word dictionary. 
        /// </summary>
        /// <param name="word">The word to be found</param>
        /// <returns>Returns the name of the category in which the passed word was found. 
        /// If no word is found, it returns null.</returns>
        public string FindServiceWordCategory(string word)
        {
            // Read every key and get his values
            foreach (KeyValuePair<string, List<string>> keyValuePair in serviceWords)
            {
                string key = keyValuePair.Key;
                List<string> values = keyValuePair.Value;

                foreach (var serviceWord in values)
                {
                    if (serviceWord == word) return key;
                }
            }
            return null;
        }

        public bool isDelimiter(string symbol)
        {
            List<string> delimiters = new List<string>()
            {
                ".", ";", ",", "(", ")", "+", "-", "*", "/", "=", ">", "<",
            };
            return delimiters.Contains(symbol);
        }
    }

    internal class Analyzer
    {
        private enum States { SCANNING, IS_WORD, IS_CONST, IS_DELIMITER, IS_ASSIGN, IS_COMMENT, ERROR, FINISHED, };
        private States _state;
        
        private ServiceWordsDictionary _serviceWordsDict = new ServiceWordsDictionary();
        public readonly List<Lex> lexemesList = new List<Lex>();

        // File reader: 
        private StringReader stringReader;
        private char[] currentChar = new char[1] { '\0' }; // A symbol that passes inspection
        private string bufferOfChars = string.Empty; // The previous characters of the word are stored here

        private int tempInt = 0; // TempInt stores a converted integer value obtained from char
                                 // (tempInt = tempInt * 10 + (int)(currentChar[0] - '0');)

        string error_message = "Unexpected error!"; // The variable stores a description of the error

        private bool CharIsInvalid(char symbol)
        {
            return (currentChar[0] == ' ' || currentChar[0] == '\n' || currentChar[0] == '\t' ||
                    currentChar[0] == '\0' || currentChar[0] == '\r');
        }

        /// <summary>
        /// Writes the next char to currentChar
        /// </summary>
        private void GetNextChar()
        {
            stringReader.Read(currentChar, 0, 1);
        }

        private void ClearBuffer()
        {
            bufferOfChars = string.Empty;
        }

        /// <summary>
        /// Adds symbol to bufferOfChars
        /// </summary>
        /// <param name="symbol">Current char to be added to the buffer</param>
        private void AddToBuffer(char symbol)
        {
            bufferOfChars += symbol;
        }

        private void AddToLexemesList(List<Lex> _lexemesList, string wordType, string wordBuffer)
        {
            _lexemesList.Add(new Lex(wordType, wordBuffer));
        }

        public List<Lex> getLexemesList(string text)
        {
            AnalyzeLexemes(text);
            return lexemesList;
        }

        private void AnalyzeLexemes(string text)
        {
            try
            {
                stringReader = new StringReader(text);

                while (_state != States.FINISHED)
                {
                    switch (_state)
                    {
                        // This state checks for matches with the list of lexemes, as well as for specific characters
                        case States.SCANNING:
                            if (CharIsInvalid(currentChar[0]))
                            {
                                GetNextChar();
                            }
                            else if (char.IsLetter(currentChar[0]))
                            {
                                ClearBuffer();
                                AddToBuffer(currentChar[0]);
                                GetNextChar();
                                _state = States.IS_WORD;
                            }
                            else if (char.IsDigit(currentChar[0]))
                            {
                                tempInt = (int)(currentChar[0] - '0');
                                AddToBuffer(currentChar[0]);
                                GetNextChar();
                                _state = States.IS_CONST;
                            }
                            else if (currentChar[0] == '{')
                            {
                                ClearBuffer();
                                AddToBuffer(currentChar[0]);
                                GetNextChar();
                                _state = States.IS_COMMENT;
                            }
                            else if (currentChar[0] == ':')
                            {
                                ClearBuffer();
                                AddToBuffer(currentChar[0]);
                                GetNextChar();
                                _state = States.IS_ASSIGN;
                            }
                            else if (currentChar[0] == '.')
                            {
                                AddToLexemesList(lexemesList, "End of program", currentChar[0].ToString());
                                MessageBox.Show("Successfuly!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _state = States.FINISHED;
                            }
                            else
                            {
                                _state = States.IS_DELIMITER;
                            }
                            break;

                        // This state tries to find a service word equal to the word in the buffer
                        case States.IS_WORD:
                            if (char.IsLetterOrDigit(currentChar[0]))
                            {
                                AddToBuffer(currentChar[0]);
                                GetNextChar();
                            }
                            else
                            {
                                string serviceWordType = _serviceWordsDict.FindServiceWordCategory(bufferOfChars);

                                // Found service word from the dictionary
                                if (serviceWordType != null)
                                {
                                    AddToLexemesList(lexemesList, serviceWordType, bufferOfChars);
                                }
                                // If the word is not found in the dictionary, write it as "Variable"
                                else
                                {
                                    AddToLexemesList(lexemesList, "Variable", bufferOfChars);
                                }
                                ClearBuffer();
                                _state = States.SCANNING;
                            }
                            break;

                        // This state looks for constants
                        // TODO: Implement float recognition
                        case States.IS_CONST:
                            if (char.IsDigit(currentChar[0]))
                            {
                                tempInt = tempInt * 10 + (int)(currentChar[0] - '0');
                                AddToBuffer(currentChar[0]);
                                GetNextChar();
                            }
                            else
                            {
                                AddToLexemesList(lexemesList, "Constant", bufferOfChars);
                                ClearBuffer();
                                _state = States.SCANNING;
                            }
                            break;

                        case States.IS_DELIMITER:
                            ClearBuffer();
                            AddToBuffer(currentChar[0]);
                            if (_serviceWordsDict.isDelimiter(bufferOfChars))
                            {
                                AddToLexemesList(lexemesList, "Delimiter", currentChar[0].ToString());
                                ClearBuffer();
                                GetNextChar();
                                _state = States.SCANNING;
                            }
                            else
                            {
                                _state = States.ERROR;
                            }
                            break;

                        case States.IS_ASSIGN:
                            if (currentChar[0] == '=')
                            {
                                AddToBuffer(currentChar[0]);
                                AddToLexemesList(lexemesList, "Assign", bufferOfChars);
                                ClearBuffer();
                                GetNextChar();
                            }
                            else
                            {
                                AddToLexemesList(lexemesList, "Type delimiter", bufferOfChars);
                            }
                            _state = States.SCANNING;
                            break;

                        case States.IS_COMMENT:
                            bool bClosingBlockFound = false;

                            AddToLexemesList(lexemesList, "Start of comment block", bufferOfChars);
                            ClearBuffer();

                            while (stringReader.Peek() >= 0)
                            {
                                GetNextChar();
                                if (currentChar[0] == '}')
                                {
                                    bClosingBlockFound = true;
                                    break;
                                }
                            }
                            if (!bClosingBlockFound)
                            {
                                error_message = "The lexical analyzer did not encounter a closing comment symbol";
                                _state = States.ERROR;
                            }
                            
                            AddToLexemesList(lexemesList, "End of comment block", currentChar[0].ToString());
                            GetNextChar();
                            _state = States.SCANNING;
                            break;

                        case States.ERROR:
                            MessageBox.Show(error_message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _state = States.FINISHED;
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception _err)
            {
                MessageBox.Show(_err.Message, "Exception", MessageBoxButtons.OK);
                throw;
            }

        }
    }
}
