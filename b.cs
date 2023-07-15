using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15072023


{

    




    public abstract class Funcionario
    {
        
        private string nome;
        private double salarioBase;

        public Funcionario(string nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        public string getNome()
        {
            return nome;
        }

        public double getSalarioBase()
        {
            return salarioBase;
        }

        public abstract double CalcularSalario();

    }
}
