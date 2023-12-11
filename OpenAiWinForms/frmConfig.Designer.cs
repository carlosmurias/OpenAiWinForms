namespace OpenAiWinForms
{
    partial class frmConfig
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtApiKey = new TextBox();
            txtMaxTokens = new TextBox();
            txtnResponses = new TextBox();
            txtTemperature = new TextBox();
            lblApiKey = new Label();
            lblMaxTokens = new Label();
            lblnResponses = new Label();
            lblTemperature = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(321, 221);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(402, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(93, 24);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(384, 23);
            txtApiKey.TabIndex = 2;
            // 
            // txtMaxTokens
            // 
            txtMaxTokens.Location = new Point(93, 53);
            txtMaxTokens.Name = "txtMaxTokens";
            txtMaxTokens.Size = new Size(100, 23);
            txtMaxTokens.TabIndex = 3;
            // 
            // txtnResponses
            // 
            txtnResponses.Location = new Point(93, 82);
            txtnResponses.Name = "txtnResponses";
            txtnResponses.Size = new Size(100, 23);
            txtnResponses.TabIndex = 4;
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(93, 111);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(100, 23);
            txtTemperature.TabIndex = 5;
            // 
            // lblApiKey
            // 
            lblApiKey.AutoSize = true;
            lblApiKey.Location = new Point(12, 27);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(47, 15);
            lblApiKey.TabIndex = 6;
            lblApiKey.Text = "API Key";
            // 
            // lblMaxTokens
            // 
            lblMaxTokens.AutoSize = true;
            lblMaxTokens.Location = new Point(12, 56);
            lblMaxTokens.Name = "lblMaxTokens";
            lblMaxTokens.Size = new Size(72, 15);
            lblMaxTokens.TabIndex = 7;
            lblMaxTokens.Text = "Max. Tokens";
            // 
            // lblnResponses
            // 
            lblnResponses.AutoSize = true;
            lblnResponses.Location = new Point(12, 85);
            lblnResponses.Name = "lblnResponses";
            lblnResponses.Size = new Size(62, 15);
            lblnResponses.TabIndex = 8;
            lblnResponses.Text = "Responses";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(12, 114);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(73, 15);
            lblTemperature.TabIndex = 9;
            lblTemperature.Text = "Temperature";
            // 
            // frmConfig
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(489, 256);
            Controls.Add(lblTemperature);
            Controls.Add(lblnResponses);
            Controls.Add(lblMaxTokens);
            Controls.Add(lblApiKey);
            Controls.Add(txtTemperature);
            Controls.Add(txtnResponses);
            Controls.Add(txtMaxTokens);
            Controls.Add(txtApiKey);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmConfig";
            Text = "Configuration";
            Load += frmConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtApiKey;
        private TextBox txtMaxTokens;
        private TextBox txtnResponses;
        private TextBox txtTemperature;
        private Label lblApiKey;
        private Label lblMaxTokens;
        private Label lblnResponses;
        private Label lblTemperature;
    }
}