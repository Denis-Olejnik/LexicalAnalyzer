using LexicalAnalyzer.LexicalAnalyzer.Source;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LexicalAnalyzer.Source
{
    class Parser
    {
        private readonly ParserRules rules = new ParserRules();

        public void GenerateAbstractSyntaxTree(TreeView treeView, List<Lex> lexes)
        {
            try
            {
                treeView.Nodes.Clear();
                treeView.Nodes.Add("E");

                TreeNode rootTreeNode = treeView.Nodes[0];
                TreeNode blockTreeNode = null;
                int blockExprIndex = 0;
                int blockBeginIndex = 0;

                // Iterate through the list of lexemes, looking at each
                for (int blockEndIndex = blockBeginIndex; blockEndIndex < lexes.Count; blockEndIndex++)
                {
                    // If a syntactically correct string ending with a semicolon is found 
                    if (lexes[blockEndIndex].type == Lex.Type.Semicolon)
                    {
                        rootTreeNode.Nodes.Add("E");

                        // The root block of the expression is temporarily stored here
                        blockTreeNode = rootTreeNode.Nodes[blockExprIndex];

                        GenerateTreeNodes(blockTreeNode, lexes, blockBeginIndex, blockEndIndex);
                        blockTreeNode.Nodes.Add(";");
                        blockBeginIndex = blockEndIndex + 1;

                        // Move to the next root block of the expression 
                        blockExprIndex++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, this.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateTreeNodes(TreeNode root, List<Lex> lexes, int _begin, int _end)
        {
            for (int i = _begin; i <= _end; i++)
            {
                // Terminal types (true, not, variable, symbols, etc)
                if (lexes[i].type == Lex.Type.Variable) AddChildNode(root, lexes[i].word);
                else if (lexes[i].type == Lex.Type.Condition) AddChildNode(root, lexes[i].word);
                else if (isLogicalType(lexes[i].type)) root.Nodes.Add(lexes[i].word);

                // Can be a nested expressions
                else if (lexes[i].word == "(")
                {
                    TreeNode parenthesisExp = root.Nodes.Add("E");
                    parenthesisExp.Nodes.Add("(");

                    TreeNode temporary = parenthesisExp.Nodes.Add("E");
                    int parenthesisEnd = i;

                    for (; parenthesisEnd < _end; parenthesisEnd++)
                    {
                        if (lexes[parenthesisEnd].word == ")")
                        {
                            GenerateTreeNodes(temporary, lexes, i + 1, parenthesisEnd);
                        }
                    }
                    i = parenthesisEnd;
                    parenthesisExp.Nodes.Add(")");
                }

                // It can be either a nested expression or a terminal type
                else if (lexes[i].type == Lex.Type.Assign)
                {
                    root.Nodes.Add(":=");

                    // If there are more than 2 tokens left in the string (a difficult expression is found)
                    if (_end - i > 2)
                    {
                        TreeNode expression = root.Nodes.Add("E");
                        GenerateTreeNodes(expression, lexes, i + 1, _end);
                        return;
                    }
                }
            }
        }


        /// <summary>
        /// Adds a child node with the specified name
        /// </summary>
        /// <param name="parent">The parent node to which to add a new node</param>
        /// <param name="name">Name of added node</param>
        private void AddChildNode(TreeNode parent, string name)
        {
            TreeNode temporary = parent.Nodes.Add("E");
            temporary.Nodes.Add(name);
        }

        private bool isLogicalType(Lex.Type type)
        {
            if (type == Lex.Type.Logical_AND || type == Lex.Type.Logical_XOR || 
                type == Lex.Type.Logical_OR || type == Lex.Type.Logical_NOT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
