using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public enum LiteratureType
    {
        Fiction,
        Methodical,
        Reference,
        Other
    }

    public class Book
    {
        private string title;
        private string author;
        private int yearOfPublication;
        private LiteratureType literatureType;

        // Конструктор
        public Book(string title, string author, int yearOfPublication, LiteratureType literatureType)
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
            LiteratureType = literatureType;
        }

        // Деструктор
        ~Book()
        {

        }

        

        // Свойства для установки и возвращения значений полей
        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    // Перевести сообщение на русский язык
                    throw new ArgumentException("Title cannot be empty.");
                title = value;
            }
        }

        public string Author
        {
            get => author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    // Перевести сообщение на русский язык
                    throw new ArgumentException("Author cannot be empty.");
                author = value;
            }
        }

        public int YearOfPublication
        {
            get => yearOfPublication;
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value <= 0 || value > currentYear)
                    // Перевести сообщение на русский язык
                    throw new ArgumentException("Year of publication must be a positive number and not in the future.");
                yearOfPublication = value;
            }
        }

        public LiteratureType LiteratureType
        {
            get => literatureType;
            set => literatureType = value;
        }

        // Метод вычисления возраста книги
        public int GetBookAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - yearOfPublication;
        }

        // Метод печати информации о книге
        public void Print()
        {
            // Перевести названия на русский язык
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year of Publication: {YearOfPublication}");
            Console.WriteLine($"Literature Type: {LiteratureType}");
            Console.WriteLine($"Age of Book: {GetBookAge()} years");
        }
        //
        // Статический метод для получения литературы из строки
        public static LiteratureType ParseLiteratureType(string input)
        {
            return input.ToLower() switch
            {
                "худож" => LiteratureType.Fiction,
                "методич" => LiteratureType.Methodical,
                "справочн" => LiteratureType.Reference,
                _ => LiteratureType.Other,
            };
        }
    }

}

