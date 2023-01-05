# Lexical analyzer

The program implements lexical and syntactic parsers. The program is written for code that is very similar to Pascal (PascalABC).

### Implemented features
- Lexical analyzer
- Syntax analyzer
- Basic error search (Unknown type/value)

### Implemented lexems
- Variable ("true" and "true1" are different)
- States (true, false)
- Separators (';' does not equal ':')

## Not implemented:
- Search for errors in the logic or spelling of lexemes
- Floating point number detection
- Arrays []
- Loops (for, while, etc)
- A lot of other things.

## Screenshots
![Program startup](/readme/0_Startup.png)

![Source file example](/readme/1_SourceFileExample.png)

![Lexical table example](/readme/2_LexicalTableExample.png?raw=true)

![Syntax tree example](/readme/3_SyntaxTreeExample.png?raw=true)

![Error example](/readme/4_ErrorExample.png?raw=true)

This abstract syntax tree is based on the file ```\Tests\Normal code Simple.txt```
![Abstract syntax tree for Sample code #1](/readme/_AbstractSyntaxTree.png)


## License

[MIT](https://choosealicense.com/licenses/mit/)

