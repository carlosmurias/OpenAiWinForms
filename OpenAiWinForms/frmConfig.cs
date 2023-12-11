using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenAiWinForms
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtApiKey.Text = Properties.Settings.Default.API_KEY;
            txtMaxTokens.Text = Properties.Settings.Default.Max_Tokens.ToString();
            txtnResponses.Text = Properties.Settings.Default.nResponses.ToString();
            txtTemperature.Text = Properties.Settings.Default.Temperature.ToString();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Guardar los valores de los TextBox en las configuraciones
            Properties.Settings.Default.API_KEY = txtApiKey.Text;

            // Asegurarse de manejar las excepciones si los valores no son válidos
            if (int.TryParse(txtMaxTokens.Text, out int maxTokens))
            {
                Properties.Settings.Default.Max_Tokens = maxTokens;
            }
            else
            {
                MessageBox.Show("El valor de Max Tokens no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin guardar
            }

            if (short.TryParse(txtnResponses.Text, out short nResponses))
            {
                Properties.Settings.Default.nResponses = nResponses;
            }
            else
            {
                MessageBox.Show("El valor de n Responses no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin guardar
            }

            if (decimal.TryParse(txtTemperature.Text, out decimal temperature))
            {
                Properties.Settings.Default.Temperature = temperature;
            }
            else
            {
                MessageBox.Show("El valor de Temperature no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin guardar
            }

            // Guardar las configuraciones
            Properties.Settings.Default.Save();

            // Cerrar el formulario
            this.Close();
        }

    }
}
