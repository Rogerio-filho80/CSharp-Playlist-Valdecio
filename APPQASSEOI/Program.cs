using System;
using System.Collections.Generic;
namespace APPQASSEOI.Entities;

class Program
{
    static void Main(string[] args)
    {
        //1. Cria a pessoa
        Pessoa P = new Pessoa();
        
        P.nome = "João da Silva";
        P.Endereco = "Rua das Flores";
        P.numero = 10;
        P.Bairro = "Centro";
        P.Cidade = "São Paulo";
        P.Estado = "SP";
        P.Cep = "01310-100";
        P.telefone = "(11) 1234-5678";
        P.dataNascimento = new DateTime(2024, 2, 20);

        //2. Cria e adiciona o primeiro dependente
        Dependente d1 = new Dependente();
        d1.Nome = "Maria da Silva";
        d1.NivelParentesco = "Filha";
        d1.ValorSF = 100;
        P.AddDependente(d1);

        //3. Cria e adiciona o segundo dependente
        Dependente d = new Dependente();
        d.Nome = "José da Silva";
        d.NivelParentesco = "Filho";
        d.ValorSF = 120;
        P.AddDependente(d);

        P.RemoveDependente(1);

        //4. Exibe o resultado
        Console.WriteLine(P.ToString());
        Console.ReadKey();

        int menu = 0;

        while (menu != 4)
        {
            Tela.MenuPrincipal();

            if (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Opção inválida! Prima qualquer tecla para tentar novamente.");
                Console.ReadKey();
                menu = 0;
                continue;
            }

            switch (menu)
            {
                case 1:
                    // Lógica para a Opção 1
                    Console.WriteLine("Executando a Opção 1...");
                    Console.ReadKey();
                    break;
                case 2:
                    // Lógica para a Opção 2
                    Console.WriteLine("Executando a Opção 2...");
                    Console.ReadKey();
                    break;
                case 3:
                    // Lógica para a Opção 3
                    Console.WriteLine("Executando a Opção 3...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("A encerrar o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Prima qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}