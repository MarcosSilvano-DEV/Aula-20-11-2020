using System;

namespace Aula_20_11_2020
{
    class Program
    {

        static float CalcularMedia(float[] numeros){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                //soma = soma + numeros[i];
                soma += numeros[i];
            }

            float calculo = soma / numeros.Length;

            return calculo;
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;

            /*
            ARRAY - APLICAÇÃO
            FOREACH
            FUNÇÃO/MÉTODO
            */

            string [] nomes      = new string[3];
            float  [] mediaAluno = new float[3];
            float  [] notas      = new float[4];

            //LAÇO CONTADO
            //O LAÇO FOR JÁ TEM NA SUA SINTAXE ELEMENTOS PARA CONAR NÚMEROS
            //OPÇÕES DE INCREMENTOS:
            // i++
            // i = i + 1
            // 1 += 1:

            for(int i = 0; i < 3; i ++){
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine();

                for(var x = 0; x < 4; x++)
                {
                    //CONCATENAÇÃO
                    Console.Write("Digite a "+(x+1)+"º nota: ");
                    notas[x] = float.Parse(Console.ReadLine());
                }

                mediaAluno[i] = CalcularMedia(notas);

            }

            Console.ForegroundColor = ConsoleColor.Blue;

            //LAÇO CONDICIONAIS
            //WHILE/DO WHILE/FOREACH

            foreach(string nomeAvulso in nomes)
            {
                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            //MOSTRAR MÉDIAS E NOMES EM LAÇOS DE REPETIÇÃO
            //ARRAY.LENGHT = TAMANHO DO ARRAY,CASO EU NÃO SAIBA (DINÂMICA)

            for(var i = 0; i < nomes.Length ; i++)
            {
                //INTERPOLAÇÃO
                Console.WriteLine($"Nome : {nomes[i]} - Média : {mediaAluno[i]} ");
            }
        }
    }
}
