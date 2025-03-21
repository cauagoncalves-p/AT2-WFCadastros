using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();

        }

        private void Error(string mensage)
        {
            MessageBox.Show(mensage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparTela()
        {
            txtNome.Clear();
            mkdCelular.Clear();
            mkdCodigo.Clear();
            txtEmail.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
        }

        private void Cadastrado(string mensage)
        {
            MessageBox.Show(mensage, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!mkdCPF.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Error("Preencha todos os campos");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Error("Preencha todos os campos");
                return;
            }

            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Error("Preencha todos os campos");
                return;
            }

            if (!mkdCelular.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!cbkPossuiFilhos.Checked)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pessoa pessoa = new Pessoa();

            pessoa.Codigo = Convert.ToInt32(mkdCodigo.Text);
            pessoa.Nome = txtNome.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.CPF = mkdCPF.Text;
            pessoa.Telefone = mkdCelular.Text;

            if (rdbComercial.Checked)
            {
                pessoa.TipoCelular = "Comercial";
            }
            else if (rdbPessoal.Checked)
            {
                pessoa.TipoCelular = "Pessoal";
            }
            else
            {
                pessoa.TipoCelular = "Recado";
            }

            if (cbkPossuiFilhos.Checked)
            {
                pessoa.PossuiFilhos = true;
            }
            else
            {
                pessoa.PossuiFilhos = false;
            }

            Cadastrado("Cadastro realizado com sucesso!");
            Pessoa.ListaCadastro.Add(pessoa);
            LimparTela();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
