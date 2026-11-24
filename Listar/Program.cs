using System.Collections.Generic;

namespace Listar;
class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>();

        lista.Add("Maria");
        lista.Add("Pedro");
        lista.Add("João");
        lista.Add("Ana");

        lista.Sort();

        foreach (string nome in lista)
        {
            Console.WriteLine(nome);
        }

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        // Concole.WriteLine("Digite um nome para buscar na lista:");
        Console.ReadKey();
    }
}
