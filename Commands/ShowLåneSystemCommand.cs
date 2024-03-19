using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal class ShowLåneSystemCommand : Command
    {
        private readonly BibliotekManagement _lånesystem;

        public ShowLåneSystemCommand(BibliotekManagement lånesystem) : base ("6", "Show Låne System List")
        {
            _lånesystem = lånesystem;
        }

        public override void Run()
        {
            Console.WriteLine();
            _lånesystem.ShowLåneSystem();
        }
    }
}
