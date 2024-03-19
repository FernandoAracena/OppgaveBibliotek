namespace AndreMøte
{
    internal class LåneSystem : BibliotekItems
    {
        private Kunde _kunde;
        private DateTime _leidedato;
        private DateTime _fristdato;

        public LåneSystem(Bok bok, Kunde kunde, DateTime leidedato, DateTime fristdato) : base(bok._title, bok._description, bok._author, bok._genre, bok._year, bok._isbn)
        {
            _kunde = kunde;
            _leidedato = leidedato;
            _fristdato = fristdato;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            _kunde.ShowKundeInfo();
            Console.Write($"leidedato : {_leidedato}");
            Console.WriteLine($"fristdato : {_fristdato}");
            Console.WriteLine();
        }

        public int ShowKundeId()
        {
            return _kunde.GetKundeId();
        }
    }
}
