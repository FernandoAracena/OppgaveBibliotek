using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class LånBookCommand : Command
    {
        private readonly BibliotekManagement _lånesystem;

        public LånBookCommand(BibliotekManagement lånesystem) : base("8", "Lån Book")
        {
            _lånesystem = lånesystem;
        }

        public override void Run()
        {
            Console.WriteLine("Select an user from the list : ");
            _lånesystem.ShowKundeList();
            int kundeindex = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Select a book from the list : ");
            _lånesystem.ShowBokList();
            int bokindex = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Input Leiedato : ");
            DateTime leidedato = DateTime.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Input Frist : ");
            DateTime fristdato = DateTime.Parse(Console.ReadLine().Trim());

            _lånesystem.LånBook(bokindex, kundeindex, leidedato, fristdato);
        }
    }
}
