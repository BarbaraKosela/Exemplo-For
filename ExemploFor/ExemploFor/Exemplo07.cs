using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo07
    {
        public Exemplo07()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite o nome " + i + ":");
                string nome = Console.ReadLine() + i;
            }
        }
    }
}
