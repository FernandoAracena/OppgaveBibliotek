using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class RemoveBookCommand : Command
    {
        private readonly BibliotekManagement _bøkerList;

        public RemoveBookCommand(BibliotekManagement bøkerList) : base("3", "Remove Book")
        {
            _bøkerList = bøkerList;
        }

        public override void Run()
        {
            Console.WriteLine("Select the index of the book to remove :");
            _bøkerList.ShowBokList();
            int index = int.Parse(Console.ReadLine().Trim());
            _bøkerList.RemoveBook(index);
        }
    }
}
