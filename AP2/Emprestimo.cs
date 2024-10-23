using System;

public class Emprestimo
{
    public Livro LivroEmprestado { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucaoPrevista { get; set; }
    public DateTime? DataDevolucao { get; set; }
    
    public Emprestimo(Livro livro, Usuario usuario, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista)
    {
        LivroEmprestado = livro;
        Usuario = usuario;
        DataEmprestimo = dataEmprestimo;
        DataDevolucaoPrevista = dataDevolucaoPrevista;
    }

    public bool EstaAtrasado()
    {
        return DataDevolucao == null && DateTime.Now > DataDevolucaoPrevista;
    }
}
