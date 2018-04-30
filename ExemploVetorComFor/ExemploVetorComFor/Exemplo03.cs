using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploVetorComFor
{
    class Exemplo03
    {
        public Exemplo03()
        {

            Console.Write("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadeDeRegistros =  Convert.ToInt32(Console.ReadLine());

            string[] fazendas = new string[quantidadeDeRegistros];
            int[] quantidadePorcos = new int[quantidadeDeRegistros];

            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("\nNome da fazenda: ");
                fazendas[i] = Console.ReadLine();
                Console.Write("\nQuantidade de suínos: ");
                quantidadePorcos[i] = Convert.ToInt32(Console.ReadLine());
            }


            //  FAZENDA COM A MAIOR QUANTIDADE DE SUÍNOS

            int maiorQuantidadeSuinos = int.MinValue;
            string fazendaMaiorQuantidadeSuinos = "";
            for (int i = 0; i < quantidadePorcos.Length; i++)
            {
                if (quantidadePorcos[i] > maiorQuantidadeSuinos)
                {
                    maiorQuantidadeSuinos = quantidadePorcos[i];
                    fazendaMaiorQuantidadeSuinos = fazendas[i];
                }
            }

            Console.WriteLine("Fazenda com maior quantidade de suínos: " + fazendaMaiorQuantidadeSuinos + " contém: " + maiorQuantidadeSuinos);


            //  FAZENDA COM O MENOR NOME

            string menorNome = "";


            for (int i = 0; i < fazendas.Length; i++)
            {
                if (fazendas[i].Length < menorNome.Length)
                {
                    menorNome = fazendas[i];
                }
            }

            Console.WriteLine("Fazenda com o menor nome: " + menorNome);

            //  Console.WriteLine("Fazendas: " + fazendas.Length);
            
        }
    }
}
