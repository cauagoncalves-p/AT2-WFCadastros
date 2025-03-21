using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Usuario
    {
        public Usuario(int codigo, string? nomeUsuario, string? senha)
        {
            Codigo = codigo;
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }

        public Usuario() 
        {
        }

        public int Codigo { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Senha { get; set; }

        public static List<Usuario> ListaCadastro = new List<Usuario>();
    }
}
