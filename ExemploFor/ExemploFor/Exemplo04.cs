using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo04
    {
        public Exemplo04()
        {
            int j = 0;

            for (int i = 0; i <= 10; i++)
            {
                    for (j = 0; j <= 10; j++)
                    {
                        int tabuada = j * i;
                        Console.WriteLine("{0} x {1} = {2}", j, i, tabuada);
                    }
                
                



            }

            


        }
    }
}
