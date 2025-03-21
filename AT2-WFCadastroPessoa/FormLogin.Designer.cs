namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
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
            btnLogar = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(49, 227);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(87, 43);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Entrar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(12, 44);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(12, 131);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 78);
            txtUsuario.MaxLength = 100;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(152, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(12, 172);
            txtSenha.MaxLength = 100;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 4;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 286);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btnLogar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}