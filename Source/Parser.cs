using LexicalAnalyzer.LexicalAnalyzer.Source;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LexicalAnalyzer.Source
{
    class Parser
    {
        private ParserRules rules = new ParserRules();
        private TreeNode lexemBlockRootNode = null;
        private TreeNode lexemBlockTemporary = null;
        private int lexemBlockStartIndex = 0;
        private int countExprBlocks = 0;

        public void GenerateAbstractSyntaxTree(TreeView treeView, List<Lex> lexesList)
        {
            try
            {
                // Just in case, clean up and create a root node of type "E"
                treeView.Nodes.Clear();
                treeView.Nodes.Add("Root");
                lexemBlockRootNode = treeView.Nodes[0];

                // Iterate through the list of lexemes, looking at each
                for (int lexemBlockEndIndex = lexemBlockStartIndex; lexemBlockEndIndex < lexesList.Count; lexemBlockEndIndex++)
                {
                    // If a syntactically correct string ending with a semicolon is found 
                    if (rules.Rule_EndsOnSemicolon(lexesList[lexemBlockEndIndex].lexemWord))
                    {
                        lexemBlockRootNode.Nodes.Add($"RootBlock {lexemBlockStartIndex} - {lexemBlockEndIndex}");

                        // The root block of the expression is temporarily stored here
                        lexemBlockTemporary = lexemBlockRootNode.Nodes[countExprBlocks];

                        // Pass from the beginning of the block to the end (lexemBlockEndIndex -> ';')
                        for (int localSearchIndex = lexemBlockStartIndex; localSearchIndex <= lexemBlockEndIndex; localSearchIndex++)
                        {
                            AddChildNodes(treeView, lexesList, localSearchIndex);
                        }
                        lexemBlockStartIndex = lexemBlockEndIndex + 1;

                        // Move to the next root block of the expression 
                        countExprBlocks++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, this.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddChildNodes(TreeView treeView, List<Lex> lexesList, int currentLexIndex)
        {
            // Array offset used to get the relative index of the elements
            int localOffset = currentLexIndex - lexemBlockStartIndex;

            // TODO: Use recursion to add nested blocks
            // TODO: if (Rule_IsVariable(lexesList, currentLexIndex) { ... }
            if (lexesList[currentLexIndex].lexemType == "Assign")
            {
                lexemBlockTemporary.Nodes.Add(":=");
            }
            else if (lexesList[currentLexIndex].lexemType == "Variable")
            {
                lexemBlockTemporary.Nodes.Add("Variable");
                lexemBlockTemporary.Nodes[localOffset].Nodes.Add(lexesList[currentLexIndex].lexemWord);
            }
            else if (lexesList[currentLexIndex].lexemWord == ";")
            {
                lexemBlockTemporary.Nodes.Add(";");
            }
            else if (lexesList[currentLexIndex].lexemType == "Statement")
            {
                lexemBlockTemporary.Nodes.Add("Condition");
                lexemBlockTemporary.Nodes[localOffset].Nodes.Add(lexesList[currentLexIndex].lexemWord);
            }
            else if (lexesList[currentLexIndex].lexemType == "")
            {

            }
            else
            {
                lexemBlockTemporary.Nodes.Add("Other");
            }
        }
    }
}
