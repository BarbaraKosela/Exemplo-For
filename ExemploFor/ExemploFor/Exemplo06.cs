using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo06
    {
        public Exemplo06()
        {
            int numero = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (numero < 10)
                {
                    Console.WriteLine("*");
                }
                else if (numero > 10)
                {
                    Console.WriteLine("* * * * * * * * * * *");
                }
            }
        }
    }
}
