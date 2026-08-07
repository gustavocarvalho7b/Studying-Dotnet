using MinhaApi.Models;

public class ProdutoService : IProdutoService
{
    private List<Produto> produtos = new();

    public List<Produto> Listar()
    {
        return produtos;
    }

    public Produto Buscar(int id)
    {
        return produtos.FirstOrDefault(x => x.Id == id);
    }

    public void Criar(Produto produto)
    {
        produtos.Add(produto);
    }
}