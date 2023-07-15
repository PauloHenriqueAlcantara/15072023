using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15072023
{
    abstract class ValidandoAluno
    {

        //metodo obrigatorio

        public abstract void ValidandoIdade(int idade);

        

    }

    class TesteValidacao : ValidandoAluno
    {

        public override void ValidandoIdade(int idade)
        {
            if (idade >= 16)
            {
                Console.WriteLine($"aluno pode fazer o curso");
            }
            else
            {
                Console.WriteLine($"aluno não pode fazer o curso");
            }
        }

    }

    class ObjAluno
    {

        public static void Main()
        {
            TesteValidacao Gabriel = new TesteValidacao();
            Gabriel.ValidandoIdade(70);

            Console.WriteLine("------------------");

            TesteValidacao Paulo = new TesteValidacao();
            Paulo.ValidandoIdade(13);
        }


    }

}
