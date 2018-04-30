using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploFor
{
    class Exemplo08
    {
        public Exemplo08()
        {
            int[] numeros = new int[] { 19, 10, 27, 26, 25, 29 };

            for (int i = 0; i < numeros.Length; i++)
			{
			    Console.WriteLine("[" +i+ "] = " + numeros[i]);
			}
            
        }
    }
}
