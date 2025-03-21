using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public class UsuarioCadastro
    {
        public UsuarioCadastro(int codigo, string? nomeCategoria, string? descricao, bool status, DateTime dataCadastro, string? categoria)
        {
            Codigo = codigo;
            NomeCategoria = nomeCategoria;
            Descricao = descricao;
            Status = status;
            DataCadastro = dataCadastro;
        }

        public UsuarioCadastro()
        {
        }

        public int Codigo { get; set; }
        public string? NomeCategoria { get; set; }
        public string? Descricao { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<UsuarioCadastro> ListaCadastro = new List<UsuarioCadastro>();


    }
}
