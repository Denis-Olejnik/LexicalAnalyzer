using System;
using System.Collections.Generic;

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
        public static readonly Dictionary<string, List<string>> serviceWords = new Dictionary<string, List<string>>()
        {
            {"Condition", new List<string> { "if", "else" } },
            {"Statement", new List<string>{ "true", "false"} },
            {"Logical", new List<string> {"xor", "or", "and", "not"} },
        };

        /// <summary>
        /// The method takes a service word and compares it against the service word dictionary. 
        /// It returns the name of the service category, for example "Statement".
        /// </summary>
        /// <param name="word">The word to be found</param>
        /// <returns>Returns the name of the category in which the passed word was found. 
        /// If no word is found, it returns string "None".</returns>
        public static string FindServiceWordCategory(string word)
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
            return "None";
        }
    }

    internal class Analyzer
    {
        /// <summary>
        /// Returns the list with the category name of the function word. {"true", "Statement"}. 
        /// If the service word is not found - it returns {"false", "None"}. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static List<string> IsServiceWord(string text)
        {
            string serviceWordCategory = ServiceWordsDictionary.FindServiceWordCategory(text);
            var serviceWordList = new List<string>();

            if (serviceWordCategory != "None")
            {
                serviceWordList.Add("true");
                serviceWordList.Add(serviceWordCategory);
                return serviceWordList;
            }
            serviceWordList.Add("false");
            serviceWordList.Add("None");
            return serviceWordList;
        }

        public static bool IsSemicolon(string text)
        {
            return (text == ";");
        }

        public static bool IsBracket(string text)
        {
            return (text == "(" || text == ")");
        }

        public static bool IsAssignOperator(string text)
        {
            return (text == "=" || text == ":=");
        }

        // What happens if a variable starts with an underscore,
        // aka a private variable?
        public static bool IsVariable(string text)
        {
            if (text.Length == 0 || !Char.IsLetter(text[0]))
            {
                return false;
            }
            else
            {
                foreach (char c in text)
                {
                    if (c != '_' && !Char.IsDigit(c) && !Char.IsLetter(c))
                    {
                        return false;
                    }
                }
            }

            return true;
            
        }

        public static bool IsCondition(string text)
        {
            return (text == "if" || text == "else");
        }
        public static bool IsStatement(string text)
        {
            return (text == "true" || text == "false");
        }

        public static bool IsLogical(string text)
        {
            return (text == "or" || text == "xor" || text == "and" || text == "not");
        }
    }
}
