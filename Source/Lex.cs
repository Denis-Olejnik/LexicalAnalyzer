using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicalAnalyzer.LexicalAnalyzer.Source
{
    public class Lex
    {
        public readonly string lexemType;
        public readonly string lexemWord;
        
        public Lex(string lexemType, string lexemWord)
        {
            this.lexemType = lexemType;
            this.lexemWord = lexemWord;
        }
    }
}
