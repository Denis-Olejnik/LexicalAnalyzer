using LexicalAnalyzer.LexicalAnalyzer.Source;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LexicalAnalyzer.Source
{
    class ParserRulesPriorities
    {
        public Dictionary<int, Lex.Type> RulesPriorities = new Dictionary<int, Lex.Type>()
        {
            {0, Lex.Type.Semicolon },
            {1, Lex.Type.Parenthesis },
            {2, Lex.Type.Logical_NOT },
            {3, Lex.Type.Logical_AND },
            {4, Lex.Type.Logical_XOR },
            {5, Lex.Type.Logical_OR },
            {6, Lex.Type.Condition },
            {7, Lex.Type.Assign },
            {8, Lex.Type.Variable },
            {9, Lex.Type.Null },
        };
    }

    class ParserRules
    {
        // TODO: Rule_IsVariable (List<Lex> lexesList, int currentLexIndex) { ... }
        public bool Rule_EndsOnSemicolon(string text)
        {
            string pattern = @";$";
            return Regex.IsMatch(text, pattern);
        }

        public bool Rule_IsVariable(string text)
        {
            string pattern = "Variable";
            return pattern == text;
        }

        public bool Rule_IsAssign(string text)
        {
            string pattern = @":=";
            return Regex.IsMatch(text, pattern);
        }

        public bool Rule_IsSemicolon(string text)
        {
            return text == ";";
        }

        public bool Rule_IsStatement(string text)
        {
            return text == "Statement";
        }
        
        /// <summary>
        /// AND, OR, XOR
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Rule_IsBinaryOperand(string text)
        {
            return text == "and" || text == "or" || text == "xor";
        }

        /// <summary>
        /// NOT
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Rule_IsUnaryOperand(string text)
        {
            return text == "not";
        }

        public bool Rule_IsOpeningParenthesis(string text)
        {
            return text == "(";
        }

        public bool Rule_IsClosingParenthesis(string text)
        {
            return text == ")";
        }

        /// <summary>
        /// Binary-AND/OR/XOR, unary-NOT, (
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Rule_IsExpression(string text)
        {
            return Rule_IsBinaryOperand(text) || Rule_IsUnaryOperand(text) || Rule_IsOpeningParenthesis(text);
        }

    }
}
