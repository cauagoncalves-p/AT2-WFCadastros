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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarLogin();
        }

        public void CarregarLogin()
        {

            Usuario.ListaCadastro.Add(new Usuario
            {
                Codigo = 001,
                NomeUsuario = "sistema",
                Senha = "123456",
            });

        }
        private void Error(string mensage)
        {
            MessageBox.Show(mensage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Logado(string messgae)
        {
            MessageBox.Show(messgae, "Logado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                Error("Preencha todos os campos");
                return;

            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Error("Preencha todos os campos");
                return;
            }

            usuario.NomeUsuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            foreach (var item in Usuario.ListaCadastro) 
            {
                if (usuario.NomeUsuario == item.NomeUsuario && usuario.Senha == item.Senha) 
                {
                    Logado("Acesso permito");
                    FormMenu formMenu = new FormMenu();
                    formMenu.ShowDialog();

                    txtSenha.Clear();
                    txtUsuario.Clear();
                    return;
                }
            }

            Error("Usuario ou senha invalidos");


        }
    }
}
