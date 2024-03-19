using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMøte.Commands
{
    internal abstract class Command
    {
        protected Command(string no, string description)
        {
            No = no;
            Description = no + " - " + description;
        }

        public string No { get;}
        public string Description { get;}

        public abstract void Run();
    }
}
