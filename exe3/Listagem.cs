class Listagem
{
    public static void ListagemVendedores()
    {
        foreach (Vendedor vendedor in Program.vendedores)
        {
            Console.WriteLine($"{vendedor.id} - {vendedor.nome} ");
        }
    }
    public static void ListagemItens()
    {
        foreach (var item in Program.itens)
        {
            Console.WriteLine($"{item.codigo} - Nome: {item.nome} - Preço: {item.preco_unidade}");
        }
    }
}