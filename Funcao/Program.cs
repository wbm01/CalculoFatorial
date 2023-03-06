internal class Program
{
    private static void Main(string[] args)
    {
        /*double numero, fat;

        Console.WriteLine("Informe o número: ");
        numero = double.Parse(Console.ReadLine());


        for (fat = 1; numero > 1; numero = numero - 1)
        {
            fat = fat*numero;
        }
        Console.WriteLine(fat);
        */

        int num;
        int resposta;

        Console.WriteLine("Informe um valor: ");
        num = int.Parse(Console.ReadLine());

        resposta = fat(num);
        Console.WriteLine("O fatorial de " + num + " é: " + resposta);

        int fat (int valor)
        {
            if (valor == 0)
            {
                return 1;
            }
            else
            {
                return (valor * fat(valor-1));
            }
        }
    }
}