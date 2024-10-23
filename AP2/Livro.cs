public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEstoque { get; set; }

    public Livro(string titulo, string autor, string isbn, string genero, int quantidadeEstoque)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEstoque = quantidadeEstoque;
    }
}