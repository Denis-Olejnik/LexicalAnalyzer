namespace LexicalAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_sourceFile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_FileViewer = new System.Windows.Forms.TextBox();
            this.button_loadFile = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.tabPage_LexicalTable = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage_sourceFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_LexicalTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_sourceFile);
            this.tabControl1.Controls.Add(this.tabPage_LexicalTable);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_sourceFile
            // 
            this.tabPage_sourceFile.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_sourceFile.Controls.Add(this.groupBox1);
            this.tabPage_sourceFile.Location = new System.Drawing.Point(4, 22);
            this.tabPage_sourceFile.Name = "tabPage_sourceFile";
            this.tabPage_sourceFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sourceFile.Size = new System.Drawing.Size(777, 434);
            this.tabPage_sourceFile.TabIndex = 0;
            this.tabPage_sourceFile.Text = "Source file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_FileViewer);
            this.groupBox1.Controls.Add(this.button_loadFile);
            this.groupBox1.Controls.Add(this.textBox_FilePath);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source file viewer";
            // 
            // textBox_FileViewer
            // 
            this.textBox_FileViewer.Location = new System.Drawing.Point(6, 46);
            this.textBox_FileViewer.Multiline = true;
            this.textBox_FileViewer.Name = "textBox_FileViewer";
            this.textBox_FileViewer.ReadOnly = true;
            this.textBox_FileViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_FileViewer.Size = new System.Drawing.Size(748, 369);
            this.textBox_FileViewer.TabIndex = 2;
            // 
            // button_loadFile
            // 
            this.button_loadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_loadFile.Location = new System.Drawing.Point(625, 18);
            this.button_loadFile.Name = "button_loadFile";
            this.button_loadFile.Size = new System.Drawing.Size(129, 22);
            this.button_loadFile.TabIndex = 1;
            this.button_loadFile.Text = "Load file";
            this.button_loadFile.UseVisualStyleBackColor = true;
            this.button_loadFile.Click += new System.EventHandler(this.button_loadFile_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(6, 19);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(613, 20);
            this.textBox_FilePath.TabIndex = 0;
            // 
            // tabPage_LexicalTable
            // 
            this.tabPage_LexicalTable.Controls.Add(this.groupBox2);
            this.tabPage_LexicalTable.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LexicalTable.Name = "tabPage_LexicalTable";
            this.tabPage_LexicalTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LexicalTable.Size = new System.Drawing.Size(777, 434);
            this.tabPage_LexicalTable.TabIndex = 1;
            this.tabPage_LexicalTable.Text = "Lexical table";
            this.tabPage_LexicalTable.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_table);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lexical table";
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.AllowUserToAddRows = false;
            this.dataGridView_table.AllowUserToDeleteRows = false;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Type,
            this.Value});
            this.dataGridView_table.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_table.MultiSelect = false;
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.ReadOnly = true;
            this.dataGridView_table.Size = new System.Drawing.Size(748, 396);
            this.dataGridView_table.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 270;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 235;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lexical analyzer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_sourceFile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_LexicalTable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_sourceFile;
        private System.Windows.Forms.TabPage tabPage_LexicalTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_loadFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.TextBox textBox_FileViewer;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}