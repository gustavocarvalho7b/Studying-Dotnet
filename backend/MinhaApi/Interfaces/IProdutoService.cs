using MinhaApi.Models;

public interface IProdutoService
{
    List<Produto> Listar();
    Produto Buscar(int id);
    void Criar(Produto produto);
}