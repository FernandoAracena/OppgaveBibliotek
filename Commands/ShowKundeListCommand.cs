using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class ShowKundeListCommand : Command
    {
        private readonly BibliotekManagement _KundeList;

        public ShowKundeListCommand(BibliotekManagement kundeList) : base ("5", "Show List of Kunder")
        {
            _KundeList = kundeList;
        }

        public override void Run()
        {
            Console.WriteLine();
            _KundeList.ShowKundeList();
        }
    }
}
