using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class RemoveKundeCommand : Command
    {
        private readonly BibliotekManagement _KundeList;

        public RemoveKundeCommand(BibliotekManagement kundeList) : base("4", "Remove Kunde")
        {
            _KundeList = kundeList;
        }

        public override void Run()
        {
            Console.WriteLine("Select the index of the kunde to remove :");
            _KundeList.ShowKundeList();
            int index = int.Parse(Console.ReadLine().Trim());
            _KundeList.RemoveKunde(index);
        }
    }
}
