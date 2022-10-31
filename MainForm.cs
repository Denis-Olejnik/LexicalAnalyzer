using LexicalAnalyzer.LexicalAnalyzer.Source;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Reading a file and writing to a text box
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            string fileContent = reader.ReadToEnd();
                            textBox_FilePath.Text = filePath;
                            textBox_FileViewer.Text = fileContent;
                        }
                        addListLexToDataTableView();
                        //dataGridView_table.Rows.Clear();

                        //// Transferring data to the method and then analyzing it
                        //Analyzer lexicAnalyzer = new Analyzer();
                        //List<Lex> lexicList = lexicAnalyzer.getLexemesList(textBox_FileViewer.Text);

                        //addListLexToDataTableView(lexicList);
                    }
                }
            }
            catch (FileNotFoundException fileNotFound)
            {
                MessageBox.Show(fileNotFound.Message, "File not found!", MessageBoxButtons.OK);
                throw;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Unexpected exception", MessageBoxButtons.OK);
                throw;
            }
        }

        private void textBox_FilePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32)(Keys.Enter))
            {
                if (File.Exists(textBox_FilePath.Text))
                {
                    addListLexToDataTableView();

                    //addListLexToDataTableView(lexicList);
                }
            }
        }

        private void addListLexToDataTableView()
        {
            dataGridView_table.Rows.Clear();

            // Transferring data to the method and then analyzing it
            Analyzer lexicAnalyzer = new Analyzer();
            List<Lex> lexicList = lexicAnalyzer.getLexemesList(textBox_FileViewer.Text);

            for (int i = 0; i < lexicList.Count; i++)
            {
                dataGridView_table.Rows.Add(i, lexicList[i].lexemWord, lexicList[i].lexemType);
            }
        }
    }
}
