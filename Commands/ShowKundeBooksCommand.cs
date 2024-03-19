using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class ShowKundeBooksCommand : Command
    {
        private readonly BibliotekManagement _KundeList;
        public ShowKundeBooksCommand(BibliotekManagement kundeList) : base("10", "Show Kunde Info")
        {
            _KundeList = kundeList;
        }

        public override void Run()
        {
            Console.WriteLine("Select the index of a Kunde :");
            _KundeList.ShowKundeList();
            int kundeindex = int.Parse(Console.ReadLine().Trim());
            _KundeList.ShowKundeBooks(kundeindex);
        }
    }
}
