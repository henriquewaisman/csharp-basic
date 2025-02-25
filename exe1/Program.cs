class Program
{
    static int quantidade_total = 0;
    static void Main(string[] args)
    {
        Console.Write("Insira o nome do produto: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Com quantos meses você quer fazer a média? ");
        int meses = int.Parse(Console.ReadLine());

        for (int i = 0; i < meses; i++)
        {
            Console.Write("Digite o estoque do mês: ");
            int quantidade_mes = int.Parse(Console.ReadLine());
            quantidade_total += quantidade_mes;
        }
        Console.WriteLine($"O estoque médio do produto {nome} é: {quantidade_total / meses}");
    }
}
