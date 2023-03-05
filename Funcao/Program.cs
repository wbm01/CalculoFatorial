internal class Program
{
    private static void Main(string[] args)
    {
        double numero, fat;

        Console.WriteLine("Informe o número: ");
        numero = double.Parse(Console.ReadLine());


        for (fat = 1; numero > 1; numero = numero - 1)
        {
            fat = fat*numero;
        }
        Console.WriteLine(fat);

    }
}