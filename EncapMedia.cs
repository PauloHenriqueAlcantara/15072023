using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFCsharp.Aula11
{
    class EncapMedia
    {
        private double Nota01, Nota02;
        private double Media;
        private double Calcular()
        {
            Media = (Nota01 + Nota02) / 2;
            return Media;
        }

        public void Mensagem()
        {
            Console.Write($"Digite a 1º Nota");
            double.TryParse(Console.ReadLine(), out Nota01);

            Console.Write($"Digite a 2º Nota");
            double.TryParse(Console.ReadLine(), out Nota02);

            Console.WriteLine($"A média final é: {Calcular()}");
        }
    }
}