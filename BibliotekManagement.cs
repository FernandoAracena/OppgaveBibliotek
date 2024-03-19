namespace AndreMøte
{
    internal class BibliotekManagement
    {
        private readonly List<Kunde> _KundeList;
        private readonly List<Bok> _bøkerList;
        private readonly List<LåneSystem> _lånesystem;
        public BibliotekManagement(List<Kunde> kundeList, List<Bok> bøkerList, List<LåneSystem> låneystem)
        {
            _KundeList = kundeList;
            _bøkerList = bøkerList;
            _lånesystem = låneystem;
        }
        public void AddBook(Bok bok)
        {
            _bøkerList.Add(bok);
        }
        public void AddKunde(Kunde kunde)
        {
            _KundeList.Add(kunde);
        }
        public void RemoveBook(int index)
        {
            _bøkerList.RemoveAt(index);
        }
        public void RemoveKunde(int index) 
        {
            _KundeList.RemoveAt(index);
        }
        public void ShowBokList()
        {
            for (int i = 0; i < _bøkerList.Count; i++)
            {
                Console.Write($"{i} - ");
                _bøkerList[i].ShowInfo();
            }
        }
        public void ShowKundeList()
        {
            for (int i = 0; i < _KundeList.Count; i++)
            {
                Console.Write($"{i} - ");
                _KundeList[i].ShowKundeInfo();
            }
        }
        public void LånBook(int indexbok, int indexkunde, DateTime leidedato, DateTime fristdato)
        {
            var bok = _bøkerList[indexbok];
            var kunde = _KundeList[indexkunde];
            bok.LåneBok();
            _lånesystem.Add(new LåneSystem(bok, kunde, leidedato, fristdato));
        }
        public void UtlånBook(int bokindex)
        {
            var bok = _bøkerList[bokindex];
            bok.LevereBok();
            AddBook(bok);
            _lånesystem.RemoveAt(bokindex);
        }
        public void ShowLåneSystem()
        {
            for (int i = 0; i < _lånesystem.Count; i++)
            {
                Console.Write($"{i} - ");
                _lånesystem[i].ShowInfo();
            }
        }
        public void ShowKundeBooks(int kundeindex)
        {
            int kundeId = _KundeList[kundeindex].GetKundeId();
            var kundebooks = _lånesystem.Where(x => x.ShowKundeId() == kundeId);
            foreach(var book in kundebooks)
            {
                book.ShowInfo();
            }
        }
    }
}
