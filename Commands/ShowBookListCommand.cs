namespace AndreMøte.Commands
{
    internal class ShowBookListCommand : Command
    {
        private readonly BibliotekManagement _bøkerList;

        public ShowBookListCommand(BibliotekManagement bøkerList) : base ("7", "Show List of Books")
        {
            _bøkerList = bøkerList;
        }

        public override void Run()
        {
            Console.WriteLine();
            _bøkerList.ShowBokList();
            Console.WriteLine();
        }
    }
}
