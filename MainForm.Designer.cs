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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_SourceFile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_FileViewer = new System.Windows.Forms.TextBox();
            this.button_openFile = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.tabPage_LexicalTable = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_SyntaxTree = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_RegenerateTreeView = new System.Windows.Forms.Button();
            this.button_ShowDeepestTreeView = new System.Windows.Forms.Button();
            this.button_ToggleTreeViewVisib = new System.Windows.Forms.Button();
            this.SyntaxTreeView = new System.Windows.Forms.TreeView();
            this.tabPage_CodeGeneration = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_SimpleButton = new System.Windows.Forms.Button();
            this.button_AnotherButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage_SourceFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_LexicalTable.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.tabPage_SyntaxTree.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_CodeGeneration.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_SourceFile);
            this.tabControl1.Controls.Add(this.tabPage_LexicalTable);
            this.tabControl1.Controls.Add(this.tabPage_SyntaxTree);
            this.tabControl1.Controls.Add(this.tabPage_CodeGeneration);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_SourceFile
            // 
            this.tabPage_SourceFile.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_SourceFile.Controls.Add(this.groupBox1);
            this.tabPage_SourceFile.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SourceFile.Name = "tabPage_SourceFile";
            this.tabPage_SourceFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SourceFile.Size = new System.Drawing.Size(777, 434);
            this.tabPage_SourceFile.TabIndex = 0;
            this.tabPage_SourceFile.Text = "Source file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_FileViewer);
            this.groupBox1.Controls.Add(this.button_openFile);
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
            this.textBox_FileViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_FileViewer.Location = new System.Drawing.Point(6, 46);
            this.textBox_FileViewer.Multiline = true;
            this.textBox_FileViewer.Name = "textBox_FileViewer";
            this.textBox_FileViewer.ReadOnly = true;
            this.textBox_FileViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_FileViewer.Size = new System.Drawing.Size(748, 369);
            this.textBox_FileViewer.TabIndex = 2;
            // 
            // button_openFile
            // 
            this.button_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_openFile.Location = new System.Drawing.Point(625, 18);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(129, 22);
            this.button_openFile.TabIndex = 1;
            this.button_openFile.Text = "Open file";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(6, 19);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(613, 20);
            this.textBox_FilePath.TabIndex = 0;
            this.textBox_FilePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FilePath_KeyPress);
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
            this.dataGridView_table.AllowUserToResizeColumns = false;
            this.dataGridView_table.AllowUserToResizeRows = false;
            this.dataGridView_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Value,
            this.Type});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_table.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_table.MultiSelect = false;
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.ReadOnly = true;
            this.dataGridView_table.RowHeadersVisible = false;
            this.dataGridView_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_table.Size = new System.Drawing.Size(748, 396);
            this.dataGridView_table.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.Width = 200;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Value.Width = 300;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 245;
            // 
            // tabPage_SyntaxTree
            // 
            this.tabPage_SyntaxTree.Controls.Add(this.groupBox3);
            this.tabPage_SyntaxTree.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SyntaxTree.Name = "tabPage_SyntaxTree";
            this.tabPage_SyntaxTree.Size = new System.Drawing.Size(777, 434);
            this.tabPage_SyntaxTree.TabIndex = 2;
            this.tabPage_SyntaxTree.Text = "Syntax tree";
            this.tabPage_SyntaxTree.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_RegenerateTreeView);
            this.groupBox3.Controls.Add(this.button_ShowDeepestTreeView);
            this.groupBox3.Controls.Add(this.button_ToggleTreeViewVisib);
            this.groupBox3.Controls.Add(this.SyntaxTreeView);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 421);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Syntax tree";
            // 
            // button_RegenerateTreeView
            // 
            this.button_RegenerateTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_RegenerateTreeView.Location = new System.Drawing.Point(343, 18);
            this.button_RegenerateTreeView.Name = "button_RegenerateTreeView";
            this.button_RegenerateTreeView.Size = new System.Drawing.Size(129, 22);
            this.button_RegenerateTreeView.TabIndex = 4;
            this.button_RegenerateTreeView.Text = "Regenerate tree";
            this.button_RegenerateTreeView.UseVisualStyleBackColor = true;
            this.button_RegenerateTreeView.Click += new System.EventHandler(this.button_RegenerateTreeView_Click);
            // 
            // button_ShowDeepestTreeView
            // 
            this.button_ShowDeepestTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_ShowDeepestTreeView.Location = new System.Drawing.Point(484, 18);
            this.button_ShowDeepestTreeView.Name = "button_ShowDeepestTreeView";
            this.button_ShowDeepestTreeView.Size = new System.Drawing.Size(129, 22);
            this.button_ShowDeepestTreeView.TabIndex = 3;
            this.button_ShowDeepestTreeView.Text = "Show deepest path";
            this.button_ShowDeepestTreeView.UseVisualStyleBackColor = true;
            this.button_ShowDeepestTreeView.Click += new System.EventHandler(this.button_ShowDeepestTreeView_Click);
            // 
            // button_ToggleTreeViewVisib
            // 
            this.button_ToggleTreeViewVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_ToggleTreeViewVisib.Location = new System.Drawing.Point(625, 18);
            this.button_ToggleTreeViewVisib.Name = "button_ToggleTreeViewVisib";
            this.button_ToggleTreeViewVisib.Size = new System.Drawing.Size(129, 22);
            this.button_ToggleTreeViewVisib.TabIndex = 2;
            this.button_ToggleTreeViewVisib.Text = "Toggle Visibility";
            this.button_ToggleTreeViewVisib.UseVisualStyleBackColor = true;
            this.button_ToggleTreeViewVisib.Click += new System.EventHandler(this.button_ToggleTreeViewVisib_Click);
            // 
            // SyntaxTreeView
            // 
            this.SyntaxTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyntaxTreeView.Location = new System.Drawing.Point(6, 46);
            this.SyntaxTreeView.Name = "SyntaxTreeView";
            this.SyntaxTreeView.Size = new System.Drawing.Size(748, 369);
            this.SyntaxTreeView.TabIndex = 0;
            // 
            // tabPage_CodeGeneration
            // 
            this.tabPage_CodeGeneration.Controls.Add(this.groupBox4);
            this.tabPage_CodeGeneration.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CodeGeneration.Name = "tabPage_CodeGeneration";
            this.tabPage_CodeGeneration.Size = new System.Drawing.Size(777, 434);
            this.tabPage_CodeGeneration.TabIndex = 3;
            this.tabPage_CodeGeneration.Text = "Code generation";
            this.tabPage_CodeGeneration.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_SimpleButton);
            this.groupBox4.Controls.Add(this.button_AnotherButton);
            this.groupBox4.Controls.Add(this.treeView1);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 421);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Code generation";
            // 
            // button_SimpleButton
            // 
            this.button_SimpleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_SimpleButton.Location = new System.Drawing.Point(484, 18);
            this.button_SimpleButton.Name = "button_SimpleButton";
            this.button_SimpleButton.Size = new System.Drawing.Size(129, 22);
            this.button_SimpleButton.TabIndex = 5;
            this.button_SimpleButton.Text = "Simple Button";
            this.button_SimpleButton.UseVisualStyleBackColor = true;
            // 
            // button_AnotherButton
            // 
            this.button_AnotherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_AnotherButton.Location = new System.Drawing.Point(625, 18);
            this.button_AnotherButton.Name = "button_AnotherButton";
            this.button_AnotherButton.Size = new System.Drawing.Size(129, 22);
            this.button_AnotherButton.TabIndex = 4;
            this.button_AnotherButton.Text = "Another Button";
            this.button_AnotherButton.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(748, 369);
            this.treeView1.TabIndex = 0;
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
            this.tabPage_SourceFile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_LexicalTable.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.tabPage_SyntaxTree.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage_CodeGeneration.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SourceFile;
        private System.Windows.Forms.TabPage tabPage_LexicalTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.TextBox textBox_FileViewer;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage_SyntaxTree;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView SyntaxTreeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.TabPage tabPage_CodeGeneration;
        private System.Windows.Forms.Button button_ToggleTreeViewVisib;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button_ShowDeepestTreeView;
        private System.Windows.Forms.Button button_SimpleButton;
        private System.Windows.Forms.Button button_AnotherButton;
        private System.Windows.Forms.Button button_RegenerateTreeView;
    }
}