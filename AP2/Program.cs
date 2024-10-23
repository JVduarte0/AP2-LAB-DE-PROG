using System;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        // Cadastrar alguns livros
        biblioteca.CadastrarLivro(new Livro("1984", "George Orwell", "123456789", "Ficção", 5));
        biblioteca.CadastrarLivro(new Livro("Dom Casmurro", "Machado de Assis", "987654321", "Clássico", 3));

        // Cadastrar alguns usuários
        biblioteca.CadastrarUsuario(new Usuario("Alan Patrick", "001", "Rua A, 123", "1234-5678"));
        biblioteca.CadastrarUsuario(new Usuario("Roger Machado", "002", "Rua B, 456", "8765-4321"));

        // Exibir livros e usuários
        Console.WriteLine("Livros disponíveis:");
        biblioteca.ExibirLivros();
        
        Console.WriteLine("\nUsuários cadastrados:");
        biblioteca.ExibirUsuarios();

        // Realizar um empréstimo
        biblioteca.RealizarEmprestimo("001", "123456789");

        // Devolver um livro
        biblioteca.DevolverLivro("001", "123456789");
    }
}
