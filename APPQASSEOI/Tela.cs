using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPQASSEOI.Entities
{
    public class Tela
    {
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("              Menu Principal                 ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 - Cadastrar Pessoa");
            Console.WriteLine("2 - Remover Pessoa");
            Console.WriteLine("3 - Listar Pessoas");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("---------------------------------------------");
            
            // Pausa a execução para o usuário conseguir ler o menu
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey(); 
        }
    }
}