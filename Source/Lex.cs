using System.Collections.Generic;

namespace LexicalAnalyzer.LexicalAnalyzer.Source
{
    // TODO: Replace text lexemType with enum?
    // This may be more convenient than the current implementation.
    // Address/search by type (.Semicolon, ,Variable) , but display static name in DataGridTable.
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
