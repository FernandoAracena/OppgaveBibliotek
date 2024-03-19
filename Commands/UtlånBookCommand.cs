using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class UtlånBookCommand : Command
    {
        private readonly BibliotekManagement _lånesystem;
        public UtlånBookCommand(BibliotekManagement lånesystem) : base ("9", "Utlån Book")
        {
            _lånesystem = lånesystem;
        }

        public override void Run()
        {
            Console.WriteLine("Select a book from the list : ");
            _lånesystem.ShowLåneSystem();
            int bokindex = int.Parse(Console.ReadLine().Trim());
            _lånesystem.UtlånBook(bokindex);
        }
    }
}
