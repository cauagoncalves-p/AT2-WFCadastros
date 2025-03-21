using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Pessoa
    {
        public Pessoa(int codigo, string? nome, string? cPF, string? email, string? telefone, string? tipoCelular, bool possuiFilhos)
        {
            Codigo = codigo;
            Nome = nome;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
            TipoCelular = tipoCelular;
            PossuiFilhos = possuiFilhos;
        }

        public Pessoa() { }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? TipoCelular { get; set; }
        public bool PossuiFilhos { get; set; }  

        public static List<Pessoa> ListaCadastro = new List<Pessoa>();
    }
}
