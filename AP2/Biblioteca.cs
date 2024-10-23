using System;
using System.Collections.Generic;
using System.Linq;

public class Biblioteca
{
    private List<Livro> livros = new List<Livro>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Emprestimo> emprestimos = new List<Emprestimo>();

    public void CadastrarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public void RealizarEmprestimo(string numeroIdentificacao, string isbn)
    {
        var usuario = usuarios.FirstOrDefault(u => u.NumeroIdentificacao == numeroIdentificacao);
        var livro = livros.FirstOrDefault(l => l.ISBN == isbn);

        if (usuario == null || livro == null || livro.QuantidadeEstoque <= 0)
        {
            Console.WriteLine("Empréstimo não pode ser realizado.");
            return;
        }

        livro.QuantidadeEstoque--;
        var emprestimo = new Emprestimo(livro, usuario, DateTime.Now, DateTime.Now.AddDays(14));
        emprestimos.Add(emprestimo);
        Console.WriteLine("Empréstimo realizado com sucesso!");
    }

    public void DevolverLivro(string numeroIdentificacao, string isbn)
    {
        var emprestimo = emprestimos.FirstOrDefault(e => e.Usuario.NumeroIdentificacao == numeroIdentificacao && e.LivroEmprestado.ISBN == isbn);
        
        if (emprestimo != null)
        {
            emprestimo.DataDevolucao = DateTime.Now;
            emprestimo.LivroEmprestado.QuantidadeEstoque++;
            Console.WriteLine("Livro devolvido com sucesso!");
        }
        else
        {
            Console.WriteLine("Empréstimo não encontrado.");
        }
    }

    public void ExibirLivros()
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.Titulo} - {livro.Autor} ({livro.QuantidadeEstoque} disponível)");
        }
    }

    public void ExibirUsuarios()
    {
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"{usuario.Nome} - ID: {usuario.NumeroIdentificacao}");
        }
    }
}
