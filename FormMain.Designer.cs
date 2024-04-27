namespace SyntaxHighlighterCS
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox_syntaxOptions = new ComboBox();
            label1 = new Label();
            button_save = new Button();
            button_open = new Button();
            richTextBox_Editor = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextBox_Editor, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(comboBox_syntaxOptions, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(button_save, 4, 0);
            tableLayoutPanel2.Controls.Add(button_open, 3, 0);
            tableLayoutPanel2.Location = new Point(1, 1);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(798, 28);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox_syntaxOptions
            // 
            comboBox_syntaxOptions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_syntaxOptions.BackColor = Color.FromArgb(64, 64, 64);
            comboBox_syntaxOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_syntaxOptions.ForeColor = Color.FromArgb(224, 224, 224);
            comboBox_syntaxOptions.FormattingEnabled = true;
            comboBox_syntaxOptions.Items.AddRange(new object[] { "JSON", "XML", "SQL", "C++", "C#", "LaTeX" });
            comboBox_syntaxOptions.Location = new Point(148, 3);
            comboBox_syntaxOptions.Name = "comboBox_syntaxOptions";
            comboBox_syntaxOptions.Size = new Size(213, 23);
            comboBox_syntaxOptions.TabIndex = 1;
            comboBox_syntaxOptions.SelectedIndexChanged += ComboBox_SyntaxOptions_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Syntax Highlighter";
            // 
            // button_save
            // 
            button_save.Anchor = AnchorStyles.None;
            button_save.BackColor = Color.Transparent;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.ForeColor = Color.FromArgb(224, 224, 224);
            button_save.Location = new Point(747, 1);
            button_save.Margin = new Padding(1);
            button_save.Name = "button_save";
            button_save.Size = new Size(50, 25);
            button_save.TabIndex = 2;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += Button_Save_Click;
            // 
            // button_open
            // 
            button_open.Anchor = AnchorStyles.None;
            button_open.BackColor = Color.Transparent;
            button_open.FlatStyle = FlatStyle.Flat;
            button_open.ForeColor = Color.FromArgb(224, 224, 224);
            button_open.Location = new Point(695, 1);
            button_open.Margin = new Padding(1);
            button_open.Name = "button_open";
            button_open.Size = new Size(50, 25);
            button_open.TabIndex = 3;
            button_open.Text = "Open";
            button_open.UseVisualStyleBackColor = false;
            button_open.Click += Button_Open_Click;
            // 
            // richTextBox_Editor
            // 
            richTextBox_Editor.AcceptsTab = true;
            richTextBox_Editor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_Editor.BackColor = Color.FromArgb(32, 32, 32);
            richTextBox_Editor.BorderStyle = BorderStyle.None;
            richTextBox_Editor.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_Editor.ForeColor = Color.White;
            richTextBox_Editor.Location = new Point(3, 33);
            richTextBox_Editor.Name = "richTextBox_Editor";
            richTextBox_Editor.Size = new Size(794, 414);
            richTextBox_Editor.TabIndex = 0;
            richTextBox_Editor.Text = "";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormMain";
            Text = "Syntax Highlighter";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private RichTextBox richTextBox_Editor;
        private ComboBox comboBox_syntaxOptions;
        private Label label1;
        private Button button_save;
        private Button button_open;
    }
}
