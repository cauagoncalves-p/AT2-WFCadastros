using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
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
            txtDescricao.Clear();
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
        }

        private void Cadastrado(string mensage)
        {
            MessageBox.Show(mensage, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            int qtdeProdutos = UsuarioCadastro.ListaCadastro.Count;
            int novoCodigo = qtdeProdutos + 1;
            mkdCodigo.Text = novoCodigo.ToString("D4");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioCadastro cadastro = new UsuarioCadastro();

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Error("Preencha todos os campos");
                return;
            }

            if (!rdbAtivo.Checked && !rdbInativo.Checked)
            {
                Error("Preencha todos os campos");
                return;
            }

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Error("Preencha todos os campos");
                return;
            }

            cadastro.NomeCategoria = txtNome.Text;
            cadastro.Descricao = txtDescricao.Text;
            cadastro.DataCadastro = dtpDataCadastro.Value;

            if (rdbAtivo.Checked)
            {
                cadastro.Status = true;
            }
            else
            {
                cadastro.Status = false;
            }

            cadastro.Codigo = UsuarioCadastro.ListaCadastro.Count + 1;
            mkdCodigo.Text = cadastro.Codigo.ToString();

            UsuarioCadastro.ListaCadastro.Add(cadastro);

            Cadastrado("Cadastrado com sucesso!");

            LimparTela();
            int qtdeProdutos = UsuarioCadastro.ListaCadastro.Count;
            int novoCodigo = qtdeProdutos + 1;
            mkdCodigo.Text = novoCodigo.ToString("D4");

        }

    }
}
