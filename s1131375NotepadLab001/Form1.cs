using System.Windows.Forms;

namespace s1131375NotepadLab001
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("new clicked");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("open clicked");

            // �[�J Form1 �ݩʡG private string currentFilePath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                richTextBox1.Text = File.ReadAllText(currentFilePath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save clicked");


            // Form1 �ݩʡG private string currentFilePath; // �p�G�� Open File, �h���Ӧ����|�Q�����I
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else { return; }
            }
            //
            File.WriteAllText(currentFilePath, richTextBox1.Text);

        }
    }
}
