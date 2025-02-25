using System.Runtime.Intrinsics.Arm;
using System.Xml.Serialization;

class Program
{
    static int vendedor_id = 0;
    static int item_id = 0;
    public static List<Vendedor> vendedores = new List<Vendedor>();
    public static List<Item> itens = new List<Item>();

    static void Main(string[] args)
    {
        vendedores.Add(new Vendedor(1, "Henrique"));
        vendedores.Add(new Vendedor(2, "Ana"));
        vendedores.Add(new Vendedor(3, "Marcos"));
        vendedores.Add(new Vendedor(4, "Victoria"));
        itens.Add(new Item(1, "Monitor", 1300));
        itens.Add(new Item(2, "Mouse", 150));
        itens.Add(new Item(3, "Caneca", 30));
        itens.Add(new Item(4, "TV", 5500));
        itens.Add(new Item(5, "Fones de Ouvido", 500));
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("MENU");
        Console.WriteLine("1 - Cadastre um vendedor");
        Console.WriteLine("2 - Cadastre um item");
        Console.WriteLine("3 - Liste os vendedores");
        Console.WriteLine("4 - Liste os itens");
        Console.WriteLine("5 - Adicione uma venda");
        Console.WriteLine("6 - Calcular Comissão");
        var op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1: CadastrarVendedor(); break;
            case 2: CadastrarItem(); break;
            case 3: ListarVendedores(); break;
            case 4: ListarItens(); break;
            case 5: AdicionarVenda(); break;
            case 6: CalcularComissao(); break;
            default: Menu(); break;
        }
    }

    static void CadastrarVendedor()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de Vendedor");
        Console.Write("Insira o nome do vendedor: ");
        string nome = Console.ReadLine();
        vendedor_id++;
        Vendedor v = new Vendedor(vendedor_id, nome);
        vendedores.Add(v);
        Thread.Sleep(200);
        Console.Clear();
        Menu();
    }
    static void CadastrarItem()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Item");
        Console.Write("Insira o nome do item: ");
        string nome_item = Console.ReadLine();
        Console.Write("Insira o preço unitário do item: ");
        double preco_item = double.Parse(Console.ReadLine());
        item_id++;
        Item i = new Item(item_id, nome_item, preco_item);
        itens.Add(i);
        Thread.Sleep(200);
        Console.Clear();
        Menu();
    }
    static void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Listagem de Vendedores");
        Listagem.ListagemVendedores();
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Menu();
    }
    static void ListarItens()
    {
        Console.Clear();
        Console.WriteLine("Listagem de Itens");
        Listagem.ListagemItens();
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Menu();
    }
    static void AdicionarVenda()
    {
        Console.Clear();
        Console.WriteLine("Adicionar Venda\n");
        Listagem.ListagemVendedores();
        Console.Write("\nDigite o código do vendedor: ");
        int codigo_vendedor = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"Vendedor: {vendedores[codigo_vendedor].nome}\n");
        Listagem.ListagemItens();
        Console.Write("\nDigite o código do item: ");
        int codigo_item = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"Item: {itens[codigo_item].nome}\n");
        Console.Write("Quantidade de itens vendidos: ");
        int quantidade_vendida = int.Parse(Console.ReadLine());
        double valor_total_da_venda = quantidade_vendida * itens[codigo_item].preco_unidade;
        Console.WriteLine($"O valor da venda foi: {valor_total_da_venda}");
        vendedores[codigo_vendedor].quantidade_vendida = valor_total_da_venda;
        Console.WriteLine("Digite uma tecla para voltar ao menu.");
        Console.ReadLine();
        Menu();
    }
    static void CalcularComissao()
    {
        Console.Clear();
        Console.WriteLine("Calcular Comissão");
        Listagem.ListagemVendedores();
        Console.Write("Digite o código do vendedor: ");
        int codigo_vendedor = int.Parse(Console.ReadLine()) - 1;
        vendedores[codigo_vendedor].comissao = vendedores[codigo_vendedor].quantidade_vendida * 0.05;
        Console.WriteLine($"O total de vendas do vendedor {vendedores[codigo_vendedor].nome} é " +
        $"{vendedores[codigo_vendedor].quantidade_vendida}. Sua comissão total é R${vendedores[codigo_vendedor].comissao}");
        Console.WriteLine("Digite uma tecla para voltar ao menu.");
        Console.ReadKey();
        Menu();
    }
}
