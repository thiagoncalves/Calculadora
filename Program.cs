using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número para ser calculado na tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Segue as informações da tabuada: \n");
            Tabuada(numero);

            Console.ReadLine();
        }
        public static void Tabuada(int numero)
        {
            int resultado;

            for (int i = 0; i <= 10; i++)
            {
                resultado = i * numero;
                Console.WriteLine(i + "x" + numero + "=" + resultado);
            }

        }
    }
}
