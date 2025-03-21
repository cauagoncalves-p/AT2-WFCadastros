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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Seja fechar o menu principal?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar formCadastrar = new FormCadastrar();
            formCadastrar.ShowDialog();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListagem formListagem = new FormListagem();
            formListagem.ShowDialog();
        }
    }
}
