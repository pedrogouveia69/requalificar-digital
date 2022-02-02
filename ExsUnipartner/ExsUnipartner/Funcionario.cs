using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsUnipartner
{

    public class Funcionario : Utilizador
    {
        public int NumFuncionario { get; set; }

        public Funcionario(string nome, string password, int numFuncionario) : base(nome, password)
        {
            NumFuncionario = numFuncionario;
        }

        public void Vender() { }
        public void RegistarHora() { }
    }
}
