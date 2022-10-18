using System;
using System.Collections.Generic;
using System.IO;
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
        private enum States { }
        private States _state;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_loadFile_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
        
        private void ReadFile()
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

            foreach (char current in fileContent + " ")
            {
                List<string> serviceWord = Analyzer.IsServiceWord(previousChars);
                bool bIsServiceWord = bool.Parse(serviceWord[0]);

                // word seems like "if, else, true, xor"
                if (bIsServiceWord)
                {
                    // if_, else_, true_, xor_
                    if (current == ' ')
                    {
                        counter++;
                        dataGridView_table.Rows.Add(counter, previousChars, serviceWord[1]);
                        previousChars = "";
                    }
                    else
                    {
                        // if(
                        if ((current == '(') && (previousChars == "if"))
                        {
                            counter++;
                            dataGridView_table.Rows.Add(counter, previousChars, serviceWord[1]);
                            previousChars = "";
                        }
                        else
                        {
                            previousChars = "";
                            // TODO: exception: IF contains another symbol, not ' ' or '('
                        }

                        // else{, else\n
                        if ((current == '{' || current == '\n') && (previousChars == "else"))
                        {
                            counter++;
                            dataGridView_table.Rows.Add(counter, previousChars, serviceWord[1]);
                            previousChars = "";
                        }
                        else
                        {
                            previousChars = "";
                            // TODO: exception: ELSE contains another symbol, not ' ' or '{'
                        }
                        
                        // true), true;
                        if ((current == ')' || current == ';') && (previousChars == "true" || previousChars == "false"))
                        {
                            counter++;
                            dataGridView_table.Rows.Add(counter, previousChars, serviceWord[1]);
                            previousChars = "";
                        }
                        else
                        {
                            previousChars = "";
                            // TODO: exception: TRUE/FALSE contains another symbol, not ')' or ';'
                        }
                        // TODO: exception: unexpected error
                    }
                }

                if (Analyzer.IsAssignOperator(previousChars) && (current == ' ' || current == ';'))
                {
                    counter++;
                    dataGridView_table.Rows.Add(counter, previousChars, "Assign");
                    previousChars = "";
                }

                if (Analyzer.IsVariable(previousChars) && !Analyzer.IsLogical(previousChars) && (current == ' ' || current == ';' || current == ')'))
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
                if (Analyzer.IsCondition(previousChars) && (current == ' ' || current == '('))
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
                previousChars += current;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPage_LexicalTable)
            {
                dataGridView_table.Rows.Clear();
                SearchLexemes();
            }
        }
    }
}
