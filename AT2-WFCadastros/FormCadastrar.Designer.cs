namespace AT2_WFCadastros
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
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            gpxStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblDataCadastro = new Label();
            dtpDataCadastro = new DateTimePicker();
            btnSalvar = new Button();
            gpxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F);
            lblCodigo.Location = new Point(12, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(60, 21);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // mkdCodigo
            // 
            mkdCodigo.Enabled = false;
            mkdCodigo.Location = new Point(88, 9);
            mkdCodigo.Mask = "0000";
            mkdCodigo.Name = "mkdCodigo";
            mkdCodigo.Size = new Size(56, 23);
            mkdCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(12, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(145, 21);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome da Categoria";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(168, 33);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 23);
            txtNome.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 281);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(297, 143);
            txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(113, 247);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 21);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição";
            // 
            // gpxStatus
            // 
            gpxStatus.Controls.Add(rdbInativo);
            gpxStatus.Controls.Add(rdbAtivo);
            gpxStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpxStatus.Location = new Point(12, 122);
            gpxStatus.Name = "gpxStatus";
            gpxStatus.Size = new Size(200, 100);
            gpxStatus.TabIndex = 6;
            gpxStatus.TabStop = false;
            gpxStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(6, 59);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(75, 25);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(6, 28);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(64, 25);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Font = new Font("Segoe UI", 12F);
            lblDataCadastro.Location = new Point(12, 81);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(129, 21);
            lblDataCadastro.TabIndex = 7;
            lblDataCadastro.Text = "Data de Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(147, 79);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(110, 23);
            dtpDataCadastro.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(88, 483);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 44);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 539);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataCadastro);
            Controls.Add(lblDataCadastro);
            Controls.Add(gpxStatus);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
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
            gpxStatus.ResumeLayout(false);
            gpxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private MaskedTextBox mkdCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private GroupBox gpxStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblDataCadastro;
        private DateTimePicker dtpDataCadastro;
        private Button btnSalvar;
    }
}