using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsUnipartner
{

    public class Funcionario : Utilizador
    {

        private int numFuncionario;

        public Funcionario(string nome, string password, int numFuncionario) : base(nome, password)
        {
            this.numFuncionario = numFuncionario;
        }

        public int NumFuncionario { get { return numFuncionario; } }

        public void vender() { }
        public void registarHora() { }
    }
}
