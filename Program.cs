using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Array150623
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();

            while (true)
            {
                Console.WriteLine("Digite 1 para buscar ou 2 para cadastrar:");
                string resposta = Console.ReadLine();

                if ( resposta == "1")
                {
                    if ( nomes.Count == 0 )
                    {
                        Console.WriteLine("A lista está vazia...");
                    }
                    else
                    {
                        int contador = 0;
                        int quantidade = nomes.Count;

                        while ( contador < quantidade)
                        {
                            Console.WriteLine($" Nome: {nomes[contador]} ");
                            contador += 1;
                        }
                    }
                }
            

                if ( resposta == "2" )
                {
                    Console.WriteLine("Digite o seu nome:");
                    string nome = Console.ReadLine();
                    nomes.Add(nome);
                    Console.WriteLine("Nome adcionado com sucesso!");
                }

                

            }

          

        }

        void repeticao()
        {
            // Laço de repetição (LOOP)
            // contador += 1; forma comum de fazer contas ou contador -= 1; ou contador *= 1; ou contador /= 1; (MAIS USADO)
            // contador ++;  => MAIS UM, SOMA APMAS UMA VEZ

            int contador = 0;

            Console.WriteLine("Olá");
            //while => enquanto, quero que repita um código

            while (contador < 5)
            {

                Console.WriteLine("Olá!");
                contador = contador + 1;



            }
        }

        void Listas ()
        {
            List<string> nomes = new List<string>();

            nomes.Add("Jonatas");
            nomes.Add("Natanael");
            nomes.Add("Bruno");



            Console.WriteLine("O Primeiro é: " + nomes[0]);
            Console.WriteLine("O Segundo é: " + nomes[1]);
            Console.WriteLine("O Terceiro é: " + nomes[2]);


            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} usuários cadastrados!");

            Console.WriteLine("Digite o seu nome:");
            nomes.Add(Console.ReadLine());                // Para deixar a pessoa digitar o nome que desejar

            nomes.RemoveAt(3);

            nomes.Remove("Natanael");


            Console.ReadKey();
        }

        void Arrays ()
        {

            // Array -> Conjunto de dados (vetor)
            // nomes[1] = Console.ReadLine(); Para a pessoa digitar o nome

            string[] nomes = new string[3];

            nomes[0] = "Kennedy";
            nomes[1] = "Rafany";
            nomes[2] = "João";

            Console.WriteLine("O nome da primeira posição é " + nomes[0]);
            Console.WriteLine("O nome da segunda posição é " + nomes[1]);
            Console.WriteLine("O nome da terceira posição é" + nomes[2]);

            Console.ReadKey();

        }
    }
}
