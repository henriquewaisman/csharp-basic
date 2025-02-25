using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Digite a cotação do dólar: ");
        double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o valor a ser convertido: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var valor_convertido = (dolar * valor).ToString("F2", CultureInfo.InvariantCulture);
        Console.WriteLine($"A quantia convertida é ${valor_convertido}");
    }
}
