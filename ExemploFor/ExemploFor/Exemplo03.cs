using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo03
    {
        public Exemplo03()
        {

            Console.WriteLine("Digite um número para multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = -1000000; i < 1000000; i++)
            {
                int multiplicar = numero * i;
                Console.WriteLine(String.Format("{0} x {1} = {2}", numero, i, multiplicar));
            }
        }
        
    }
}
