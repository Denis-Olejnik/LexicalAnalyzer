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
    internal class Analyzer
    {
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
