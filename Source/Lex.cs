namespace LexicalAnalyzer.LexicalAnalyzer.Source
{
    // TODO: Replace text type with enum?
    // This may be more convenient than the current implementation.
    // Address/search by type (.Semicolon, ,Variable) , but display static name in DataGridTable.



    public class Lex
    {
        public readonly Type type;
        public readonly string word;

        public enum Type
        {
            Assign,                 // :=
            Colon,                  // :
            Comment_Open,           // {
            Comment_Close,          // }
            End,                    // .
            Logical_AND,            // and
            Logical_NOT,            // not
            Logical_OR,             // or
            Logical_XOR,            // xor
            Parenthesis,            // ()
            Semicolon,              // ;
            Condition,              // true/false
            Constant,               // const
            Variable,               // variable
            Null,                   // null-value
        }

        public Lex(Type _lexemType, string _lexemWord)
        {
            this.type = _lexemType;
            this.word = _lexemWord;
        }

    }
}
