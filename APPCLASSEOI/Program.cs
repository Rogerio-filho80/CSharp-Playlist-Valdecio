namespace APPCLASSEOI;
class Program
{
    static void Main(string[] args)
    {
        string name = "João da Silva";

        string SobreNome = name.Substring(8, 5);

        Console.WriteLine(SobreNome);

        Console.ReadKey();
    }
}
