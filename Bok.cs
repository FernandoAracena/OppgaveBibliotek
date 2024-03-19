namespace AndreMøte
{
    internal class Bok : BibliotekItems
    {
        private bool _isavailable;
        public Bok(string title, string description, string author, string genre, int year, string isbn, bool isavailable) : base(title, description, author, genre, year, isbn)
        {
            _isavailable = isavailable;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string availability = _isavailable ? "AVAILABLE" : "NOT AVAILABLE";
            Console.WriteLine($"    {availability}");
        }
        public bool IsAvailable()
        {
            return _isavailable;
        }
        public void LåneBok()
        {
            _isavailable = false;
        }
        public void LevereBok()
        {
            _isavailable = true;
        }
    }
}
