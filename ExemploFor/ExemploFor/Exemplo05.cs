using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo05
    {
        public Exemplo05()
        {
            int tamanho = 10;
            for (int i = 0; i <= tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                     Console.Write("* ");
                }
                Console.WriteLine(); 
            }

        }
    }
}
