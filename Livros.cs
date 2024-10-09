using GestaoLivraria.Enums;

namespace GestaoLivraria;

public class Livros
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public TypeLivro Gender {  get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}