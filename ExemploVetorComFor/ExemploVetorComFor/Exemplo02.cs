using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo02
    {
        public Exemplo02()
        {
            // QUAL O LVL NO LOL

            int[] levelNoLOL = new int[5];
            //  PREENCHER O VETOR

            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                Console.Write("Digite o seu level no LOL: ");
                levelNoLOL[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // SOMA DOS VALORES CONTIDOS NO VETOR
            // PARA POSTERIORMENTE PODER REALIZAR A MÉDIA

            int somaLevels = 0;
            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                somaLevels = levelNoLOL[i] + somaLevels;
            }

            double mediaLevel = somaLevels / levelNoLOL.Length; // ASSIM O NÚMERO NÃO FICARÁ FIXO 
            Console.WriteLine("A média de levels é: " + mediaLevel);
            
        }
    }
}
