using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * It is necessary to replace this implementation with normal code. 
 * For example, value pairs: "type" : "value_1", "value_2"
 * "Operator" : '=', '>', '<', '+', '-', etc.
*/

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
        public static Dictionary<string, List<string>> serviceWords = new Dictionary<string, List<string>>()
        {
            {"Condition", new List<string> { "if", "else" } },
            {"Statement", new List<string>{ "true", "false"} },
            {"Logical", new List<string> {"xor", "or", "and", "not"} }
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
        public static bool IsServiceWord(string text)
        {
            string returnValue = ServiceWordsDictionary.FindServiceWordCategory(text);
            if (returnValue != "None")
            {
                return true;
            }
            return false;
        }

        public static bool IsSemicolon(string text)
        {
            return (text == ";");
        }
        
        public static bool IsCondition(string text)
        {
            return (text == "if" || text == "else");
        }

        public static bool IsStatement(string text)
        {
            return (text == "true" || text == "false");
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

        public static bool IsLogical(string text)
        {
            return (text == "or" || text == "xor" || text == "and" || text == "not");
        }

    }
}
