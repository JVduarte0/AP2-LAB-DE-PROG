// Classe base abstrata
public abstract class ItemBiblioteca
{
    // Propriedades
    public int Id { get; set; }
    public string Titulo { get; set; }
    protected string DescricaoInterna { get; set; }

    // Construtor
    protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "O livro está em uso no momento";
    }
}