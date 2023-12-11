namespace OpenAiWinForms
{
    public partial class frmPrincipal : Form
    {

        private GptApiHandler _gptApiHandler;

        public frmPrincipal()
        {
            InitializeComponent();
            _gptApiHandler = new GptApiHandler(null);
        }

        private async void btnGenerateText_Click(object sender, EventArgs e)
        {
            try
            {
                string prompt = txtPrompt.Text;
                string generatedText = await _gptApiHandler.GenerateTextAsync(prompt);
                richTextBoxOutput.Text = generatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig frm = new frmConfig();
            frm.ShowDialog();
        }
    }
}