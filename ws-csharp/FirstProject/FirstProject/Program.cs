using FirstProject.Model;

internal class Program
{
    private static void Main(string[] args)
    {

        var nome = "fiap";

        int valor = 10;

        List<int> lista = new List<int>();

        for (int i = 0; i < valor; i++)
        {
            lista.Add(i);
        }

        lista.ForEach(x => Console.WriteLine(x));

        foreach (var vlr in lista)
        {
            Console.WriteLine(vlr);
        }
    }
}