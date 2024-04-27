namespace SyntaxHighlighterCS
{
    public partial class FormMain : Form
    {
        private readonly HighlighterRules highlighterRules;
        public FormMain()
        {
            InitializeComponent();
            comboBox_syntaxOptions.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox_syntaxOptions.DrawItem += comboBox_syntaxOptions_DrawItem;
            FillComboBoxWithEnum();
            highlighterRules = new HighlighterRules(richTextBox_Editor);
            richTextBox_Editor.TextChanged += (sender, e) => highlighterRules.HighlightSyntax();

        }

        private void comboBox_syntaxOptions_DrawItem(object? sender, DrawItemEventArgs? e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                string text = comboBox_syntaxOptions.Items[e.Index].ToString();
                using Brush br = new SolidBrush(e.ForeColor);
                e.Graphics.DrawString(text, e.Font, br, e.Bounds);
            }
        }

        private void FillComboBoxWithEnum()
        {
            comboBox_syntaxOptions.Items.Clear();

            foreach (string option in Enum.GetNames(typeof(HighlighterOptions)))
            {
                comboBox_syntaxOptions.Items.Add(option);
            }
        }

        private void ComboBox_SyntaxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            highlighterRules.SelectOption((HighlighterOptions)comboBox_syntaxOptions.SelectedIndex);
            highlighterRules.HighlightSyntax();
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox_Editor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox_Editor.Text);
            }
        }
    }
}
