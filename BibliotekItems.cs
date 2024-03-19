namespace AndreMøte
{
    internal class BibliotekItems
    {
        protected internal string _title;
        protected internal string _description;
        protected internal string _author;
        protected internal string _genre;
        protected internal int _year;
        protected internal string _isbn;
        public BibliotekItems(string title, string description, string author, string genre, int year, string isbn)
        {
            _title = title;
            _description = description;
            _author = author;
            _genre = genre;
            _year = year;
            _isbn = isbn;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"title : {_title} - author : {_author} - genre : {_genre} - year : {_year} - isbn : {_isbn}");
        }
    }
}
