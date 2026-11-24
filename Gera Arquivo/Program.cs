using System;
using System.Collections.Generic;
using System.IO;

namespace GERARRQUIVONF8
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemmenu = 0;
            while (itemmenu != 3)
            {
                switch (itemmenu)
                {
                    case 0:
                        Menu();
                        string input = Console.ReadLine();
                        // Evita que o programa quebre se o usuário digitar letras
                        if (int.TryParse(input, out int opcao))
                        {
                            itemmenu = opcao;
                        }
                        else
                        {
                            itemmenu = 0;
                        }
                        break;
                    case 1:
                        LerArquivo();
                        itemmenu = 0; // Retorna ao menu principal
                        break;
                    case 2:
                        GravarArquivo();
                        itemmenu = 0; // Retorna ao menu principal
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        itemmenu = 0;
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione a opção de menu:");
            Console.WriteLine("1 - Leitura do arquivo");
            Console.WriteLine("2 - Gravar arquivo");
            Console.WriteLine("3 - Sair");
        }

        static void LerArquivo()
        {
            // Path.Combine é a forma mais segura de juntar caminhos de diretórios
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listarnomes.txt");
            
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Arquivo " + caminhoArquivo + " não foi encontrado.");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void GravarArquivo()
        {
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listarnomes.txt");
            
            Console.Clear();
            List<string> nomes = new List<string>();
            Console.WriteLine("Informe o texto a ser gravado no arquivo (digite ## para terminar):");
            
            while (true)
            {
                string linha = Console.ReadLine();
                // StartsWith é mais seguro que Substring para evitar erro em linhas vazias
                if (linha != null && linha.StartsWith("##"))
                {
                    break;
                }
                else
                {
                    nomes.Add(linha);
                }
            }
            
            // Ordena a lista alfabeticamente
            nomes.Sort();
            
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (string linha in nomes)
                {
                    writer.WriteLine(linha);
                }
            }
            Console.WriteLine("Arquivo gravado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}