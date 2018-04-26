using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo01
    {
        public Exemplo01()
        {
            string[] mortesDoFilme = new string[5];
            //FORMA OLD
            // mortesDoFilme[0] = "Tony Stark";

            for (int i = 0; i < mortesDoFilme.Length; i++) //Armazena as informações
			{
                Console.Write("Digite o nome da pessoa que morreu no filme:");
                mortesDoFilme[i] = Console.ReadLine();
			}


            // APRESENTAR AS INFORMAÇÕES DO VETOR

            Console.Clear();
            Console.WriteLine("Pessoas cadastradas: ");
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.WriteLine("Nome: " + mortesDoFilme[i]);
            }
        }
    }
}
