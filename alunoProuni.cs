using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFCsharp.Aula11
{
    class AlunoProuni : AlunoPadrao
    {
        public override void DescontoParcela(double parcela)
        {
            Console.WriteLine($"Valor do desconto: {parcela * 0.10}");
        }
    }
}
