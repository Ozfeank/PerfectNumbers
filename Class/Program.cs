using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "Jane Eyre";
            book1.Writer = "Charlotte Brontë";
            book1.NumberofPage = 632;
            book1.ReleaseDate = "1847";

            Book book2 = new Book();
            book2.Name = "Love and Pride";
            book2.Writer = "Jane Austen";
            book2.NumberofPage = 444;
            book2.ReleaseDate = "1813";

            Book book3 = new Book();
            book3.Name = "Frankstein";
            book3.Writer = "Mary Shelley";
            book3.NumberofPage = 280;
            book3.ReleaseDate = "1823";

            Book book4 = new Book();
            book4.Name = "Middlemarch";
            book4.Writer = "George Eliot";
            book4.NumberofPage = 348;
            book4.ReleaseDate = "1871";

            Book[] books = new Book[] { book1, book2, book3 };

            Random rnd = new Random();
            int random = rnd.Next(0, books.Length);

            Console.WriteLine(" Name = "+  books[random].Name);
            Console.WriteLine(" Writer = " + books[random].Writer);
            Console.WriteLine(" Number of Pages = " + books[random].NumberofPage);
            Console.WriteLine(" Release Date  = " + books[random].ReleaseDate);

            Console.ReadLine();
        }
    }
}
