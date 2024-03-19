using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class AddKundeCommand : Command
    {
        private readonly BibliotekManagement _KundeList;

        public AddKundeCommand(BibliotekManagement kundeList) : base("2", "Add new Kunde")
        {
            _KundeList = kundeList;
        }

        public override void Run()
        {
            Console.WriteLine("Input kunde name :");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Input kunde Id :");
            int kundeId = int.Parse(Console.ReadLine().Trim());
            var kunde = new Kunde(name, kundeId);
            _KundeList.AddKunde(kunde);
        }
    }
}
