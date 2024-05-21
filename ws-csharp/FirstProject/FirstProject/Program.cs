using FirstProject.Model;
using FirstProject.Exceptions;

internal class Program
{
    static void Main(string[] args)
    {

        //var nome = "fiap";

        //int valor = 10;

        //List<int> lista = new List<int>();

        //for (int i = 0; i < valor; i++)
        //{
        //    lista.Add(i);
        //}

        //lista.ForEach(x => Console.WriteLine(x));

        //foreach (var vlr in lista)
        //{
        //    Console.WriteLine(vlr);
        //}
        try
        {
            throw new PersonalizadaException("Erro personalizado");
        }
        catch (PersonalizadaException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.Read();
    }
}