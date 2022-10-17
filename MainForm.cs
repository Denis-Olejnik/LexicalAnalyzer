using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
    varName
    true false
    =
    or xor and not 
    ( )
 */
namespace LexicalAnalyzer
{
    public partial class MainForm : Form
    {
        private string fileContent = string.Empty;
        private string filePath = string.Empty;
        
        private Dictionary<string, string> lexemPair = new Dictionary<string, string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_loadFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Here we open, read and save data from the file 
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        textBox_FilePath.Text = filePath;
                        textBox_FileViewer.Text = fileContent;

                        SearchLexemes();
                        //update_DataGridView_table();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK);
                throw;
            }

        }

        private void SearchLexemes()
        {
            // Sequential number of the lexeme
            int counter = 0;

            // The variable stores the previous characters in case
            // none of the checks are passed.
            string previousChars = string.Empty;

            foreach (char c in fileContent + " ")
            {
                
                if (Analyzer.IsLogical(previousChars) && (c == ' ' || c == ';'))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Logical");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (Analyzer.IsStatement(previousChars) && (c == ' ' || c == ';'))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Statement");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (Analyzer.IsAssignOperator(previousChars) && (c == ' ' || c == ';'))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Assign");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (Analyzer.IsVariable(previousChars) && 
                    !Analyzer.IsLogical(previousChars) && (c == ' ' || c == ';' || c == ')'))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Variable");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (Analyzer.IsSemicolon(previousChars))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Semicolon");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (Analyzer.IsBracket(previousChars))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Bracket");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (Analyzer.IsCondition(previousChars) && (c == ' ' || c == '('))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Condition");
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }

                if (previousChars == Environment.NewLine || previousChars == " ")
                {
                    previousChars = "";
                    //previousChars += c;
                    //continue;
                }
                previousChars += c;
                //Debug.WriteLine(lexemPair);
            }
            
        }

        private void update_DataGridView_table()
        {
            //datagridview_table.rows.add("test1", "test2", "test3");
        }
    }
}
