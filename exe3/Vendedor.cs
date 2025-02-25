class Vendedor
{
    public int id;
    public string nome;
    public double quantidade_vendida;
    public double comissao;

    public Vendedor(string nome)
    {
        this.nome = nome;
    }
    public Vendedor(int id, string nome) : this(nome)
    {
        this.id = id;
    }
}