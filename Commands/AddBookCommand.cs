using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class AddBookCommand : Command
    {
        private readonly BibliotekManagement _bøkerList;

        public AddBookCommand(BibliotekManagement bøkerList) : base("1", "Add new Book")
        {
            _bøkerList = bøkerList;
        }

        public override void Run()
        {
            Console.WriteLine("Input Title :");
            string title = Console.ReadLine().Trim();
            Console.WriteLine("Input description :");
            string description = Console.ReadLine().Trim();
            Console.WriteLine("Input author :");
            string author = Console.ReadLine().Trim();
            Console.WriteLine("Input genre :");
            string genre = Console.ReadLine().Trim();
            Console.WriteLine("Input year :");
            int year = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Input isbn :");
            string isbn = Console.ReadLine().Trim();
            Console.WriteLine("Is the book available ? (true / false) :");
            bool isavailable = bool.Parse(Console.ReadLine().Trim());
            var bok = new Bok(title, description, author, genre, year, isbn, isavailable);
            _bøkerList.AddBook(bok);
        }
    }
}
