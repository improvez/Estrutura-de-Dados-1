// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;
using BookList;

Console.WriteLine("Bem vindo ao cadastro de um livro!!");

List<Book> bookList = new List<Book>();

Console.Write("Informe quantos livros você quer cadastrar: ");
int? numeroDeCadastros = Convert.ToInt32(Console.ReadLine());
int counter = 0;

do {
    Console.WriteLine("Informe o Nome: ");
    string? nome = Console.ReadLine();

    Console.WriteLine("Informe o Editora: ");
    string? editora = Console.ReadLine();

    Console.WriteLine("Informe o Autor: ");
    string? autor = Console.ReadLine();

    Console.WriteLine("Informe o Numero de Páginas: ");
    int? numero = Convert.ToInt32(Console.ReadLine());
    
    bookList.Add(new Book(){
        Nome = nome,
        Editora = editora,
        Autor = autor,
        NumeroDePaginas = numero
    });

    counter++;

} while((numeroDeCadastros - 1) >= counter);

int? high = 0;
Book highBook = new Book();

foreach (Book book in bookList) {
    if (high < book.NumeroDePaginas) {
        highBook = book;
    }
}

Console.WriteLine($"O livro com mais página é o {highBook.Nome}");


