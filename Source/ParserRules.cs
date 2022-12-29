using System.Text.RegularExpressions;

namespace LexicalAnalyzer.Source
{
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
            string pattern = @"";
            return Regex.IsMatch(text, pattern);
        }

        public bool Rule_IsAssign(string text)
        {
            string pattern = @":=";
            return Regex.IsMatch(text, pattern);
        }


    }
}
