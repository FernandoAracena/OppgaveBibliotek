namespace AndreMøte
{
    internal class Kunde
    {
        private string _name;
        private int _kundeId;

        public Kunde(string name, int kundeId)
        {
            _name = name;
            _kundeId = kundeId;
        }

        public void ShowKundeInfo()
        {
            Console.WriteLine($"name : {_name} - kundeId : {_kundeId}");
        }

        public int GetKundeId()
        {
            return _kundeId;
        }
    }
}
