using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string numLivrosSTR;
            int numLivrosINT;
            string titulo, autor;
            Book[] books;


            Console.WriteLine("Quantos livros tem?");
            numLivrosSTR = Console.ReadLine();
            numLivrosINT = Convert.ToInt32(numLivrosSTR);

            books = new Book[numLivrosINT];

            for (int i = 0; i < numLivrosINT; i++)
            {
                string title, author;
                Book b;

                Console.WriteLine("\nQual o título do livro " + (i + 1) + "?");
                title = Console.ReadLine();

                Console.WriteLine("E o autor?");
                author = Console.ReadLine();

                b = new Book(title, author);
                books[i] = b;
            }

            foreach (Book b in books)
            {
                Console.WriteLine("");
                Console.WriteLine($"Título: {b.GetTitle()}");
                Console.WriteLine("Comprimento: {0}", b.GetTitleLength());
                Console.WriteLine("Autor:" +  b.GetTitle());
            }


            Console.WriteLine(Book.GetTotalBooks());
        }
    }
}
