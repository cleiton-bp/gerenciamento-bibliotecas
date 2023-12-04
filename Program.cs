using gerenciamento_biblioteca;
internal class Program
{
    private static void Main(string[] args)
    {
        // criando os livros
        var livro1 = new Livro("Harry Potter", "J.K. Rowling","livros sobre um jovem bruxo, Harry Potter");
        var livro2 = new Livro("O Menino Maluquinho", "Ziraldo");

        // exibindo descricao do livro 
        livro1.ExibirDescricaoInterna();
        livro2.ExibirDescricaoInterna();

        // criando a biblioteca
        var biblioteca1 = new Biblioteca();

        //adicionando livro a biblioteca
        biblioteca1.AdicionarItem(livro1);
        biblioteca1.AdicionarItem(livro2);

        // buscando pelo id
        var resultado1 = biblioteca1.BuscarItemPorId(1);
        var resultado2 = biblioteca1.BuscarItemPorId(2);

        // exibindo a busca por id
        Console.WriteLine($"Livro = id: {resultado1.Id} Titulo: {resultado1.Titulo}, Autor: {resultado1.Autor}.");
        Console.WriteLine($"Livro = id: {resultado2.Id} Titulo: {resultado2.Titulo}, Autor: {resultado2.Autor}.");

        //buscando pelo titulo 
        var resultado3 = biblioteca1.BuscarItemPorTitulo("O Menino Maluquinho");
        var resultado4 = biblioteca1.BuscarItemPorTitulo("Harry Potter");

        //exibindo a busca por titulo
        Console.WriteLine($"Livro = id: {resultado3.Id} Titulo: {resultado3.Titulo}, Autor: {resultado3.Autor}.");
        Console.WriteLine($"Livro = id: {resultado4.Id} Titulo: {resultado4.Titulo}, Autor: {resultado4.Autor}.");

        // removendo os livros da biblioteca 
        // biblioteca1.RemoverItem(livro1);
        // biblioteca1.RemoverItem(livro2);
    

        // testando que removeu
        var testeRemocao1 = biblioteca1.BuscarItemPorId(2);
        var testeRemocao2 = biblioteca1.BuscarItemPorTitulo("Harry Potter");

        if (testeRemocao1 == null)
            Console.WriteLine("4: livro nao existe mais.");
        else
            Console.WriteLine("3: livro esta na biblioteca");

        if (testeRemocao2 == null)
            Console.WriteLine("2: livro nao existe mais.");
        else
            Console.WriteLine("1: livro esta na biblioteca");
    }
}
