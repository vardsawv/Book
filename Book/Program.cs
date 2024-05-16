using System;

namespace Book
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите название книги: ");
                string title = Console.ReadLine();

                Console.Write("Введите автора книги: ");
                string author = Console.ReadLine();

                Console.Write("Введите год выпуска книги: ");
                int yearOfPublication = int.Parse(Console.ReadLine());

                Console.Write("Введите вид литературы (худож., методич., справочн.,): ");
                string literatureTypeInput = Console.ReadLine();
                LiteratureType literatureType = Book.ParseLiteratureType(literatureTypeInput);

                Book book = new Book(title, author, yearOfPublication, literatureType);
                book.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
