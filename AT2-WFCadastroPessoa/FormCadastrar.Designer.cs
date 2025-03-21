namespace AT2_WFCadastroPessoa
{
    partial class FormCadastrar
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
            lblCodigo = new Label();
            mkdCodigo = new MaskedTextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            gpxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            lblCelular = new Label();
            btnSalvar = new Button();
            mkdCPF = new MaskedTextBox();
            lblCPF = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mkdCelular = new MaskedTextBox();
            cbkPossuiFilhos = new CheckBox();
            btnVoltar = new Button();
            gpxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F);
            lblCodigo.Location = new Point(8, 33);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(60, 21);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // mkdCodigo
            // 
            mkdCodigo.Enabled = false;
            mkdCodigo.Location = new Point(77, 33);
            mkdCodigo.Mask = "0000";
            mkdCodigo.Name = "mkdCodigo";
            mkdCodigo.Size = new Size(56, 23);
            mkdCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(8, 93);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(125, 21);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(8, 132);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(309, 23);
            txtNome.TabIndex = 3;
            // 
            // gpxTipoTelefone
            // 
            gpxTipoTelefone.Controls.Add(rdbRecado);
            gpxTipoTelefone.Controls.Add(rdbComercial);
            gpxTipoTelefone.Controls.Add(rdbPessoal);
            gpxTipoTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpxTipoTelefone.Location = new Point(162, 274);
            gpxTipoTelefone.Name = "gpxTipoTelefone";
            gpxTipoTelefone.Size = new Size(200, 135);
            gpxTipoTelefone.TabIndex = 6;
            gpxTipoTelefone.TabStop = false;
            gpxTipoTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(6, 90);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(79, 25);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(6, 59);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(98, 25);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 28);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(79, 25);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 12F);
            lblCelular.Location = new Point(12, 274);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(98, 21);
            lblCelular.TabIndex = 7;
            lblCelular.Text = "DDD/Celular";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(209, 466);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 44);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mkdCPF
            // 
            mkdCPF.Location = new Point(209, 35);
            mkdCPF.Mask = "000,000,000-00";
            mkdCPF.Name = "mkdCPF";
            mkdCPF.Size = new Size(100, 23);
            mkdCPF.TabIndex = 12;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 12F);
            lblCPF.Location = new Point(154, 35);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(37, 21);
            lblCPF.TabIndex = 14;
            lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(8, 214);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 23);
            txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(12, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // mkdCelular
            // 
            mkdCelular.Location = new Point(12, 307);
            mkdCelular.Mask = "(00) 00000-0000";
            mkdCelular.Name = "mkdCelular";
            mkdCelular.Size = new Size(100, 23);
            mkdCelular.TabIndex = 17;
            // 
            // cbkPossuiFilhos
            // 
            cbkPossuiFilhos.AutoSize = true;
            cbkPossuiFilhos.Checked = true;
            cbkPossuiFilhos.CheckState = CheckState.Indeterminate;
            cbkPossuiFilhos.Location = new Point(12, 370);
            cbkPossuiFilhos.Name = "cbkPossuiFilhos";
            cbkPossuiFilhos.Size = new Size(92, 19);
            cbkPossuiFilhos.TabIndex = 18;
            cbkPossuiFilhos.Text = "Possui filhos";
            cbkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(23, 466);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(124, 44);
            btnVoltar.TabIndex = 19;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 539);
            Controls.Add(btnVoltar);
            Controls.Add(cbkPossuiFilhos);
            Controls.Add(mkdCelular);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblCPF);
            Controls.Add(mkdCPF);
            Controls.Add(btnSalvar);
            Controls.Add(lblCelular);
            Controls.Add(gpxTipoTelefone);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(mkdCodigo);
            Controls.Add(lblCodigo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de cadastro";
            Load += FormCadastrar_Load;
            gpxTipoTelefone.ResumeLayout(false);
            gpxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private MaskedTextBox mkdCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox gpxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private Label lblCelular;
        private Button btnSalvar;
        private MaskedTextBox mkdCPF;
        private Label lblCPF;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox mkdCelular;
        private RadioButton rdbRecado;
        private CheckBox cbkPossuiFilhos;
        private Button btnVoltar;
    }
}