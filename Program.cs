using AndreMøte.Commands;

namespace AndreMøte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bøkerList = new List<Bok>
            {
                new Bok("The Great Gatsby", "A story of the fabulously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan.", "F. Scott Fitzgerald", "Classic Fiction", 1925, "9780743273565", false),
                new Bok("To Kill a Mockingbird", "A novel set in the American South during the 1930s, addressing racial injustice.", "Harper Lee", "Classic Fiction", 1960, "9780060935467", false),
                new Bok("1984", "A dystopian social science fiction novel by George Orwell.", "George Orwell", "Science Fiction", 1949, "9780451524935", false),
                new Bok("Pride and Prejudice", "A novel of manners, centering on the Bennet family and their five unmarried daughters.", "Jane Austen", "Classic Fiction", 1813, "9780486284736", true),
                new Bok("The Catcher in the Rye", "A story of teenage angst and alienation in the life of a young man named Holden Caulfield.", "J.D. Salinger", "Classic Fiction", 1951, "9780316769488", true),
                new Bok("The Hobbit", "A fantasy novel about the adventures of Bilbo Baggins, a hobbit who embarks on a quest to reclaim a stolen treasure.", "J.R.R. Tolkien", "Fantasy", 1937, "9780547928227", true),
                new Bok("Jane Eyre", "A novel follows the emotions and experiences of its eponymous character, including her growth to adulthood.", "Charlotte Brontë", "Classic Fiction", 1847, "9780141441146", true),
                new Bok("The Girl with the Dragon Tattoo", "A psychological thriller novel following journalist Mikael Blomkvist and hacker Lisbeth Salander.", "Stieg Larsson", "Mystery", 2005, "9780307454546", true),
                new Bok("Sapiens: A Brief History of Humankind", "An exploration of the history of Homo sapiens, from the emergence of archaic human species to modern times.", "Yuval Noah Harari", "Non-Fiction", 2011, "9780062316097", true),
                new Bok("Harry Potter and the Sorcerer's Stone", "The first book in the Harry Potter series, following the adventures of a young wizard.", "J.K. Rowling", "Fantasy", 1997, "9780590353427", true)
            };
            var kundeList = new List<Kunde>
            {
                new Kunde("Kunde1", 001),
                new Kunde("Kunde2", 002),
                new Kunde("Kunde3", 003)
            };
            var lånesystem = new List<LåneSystem>
            {
                new LåneSystem(bøkerList[0], kundeList[0], DateTime.Now, DateTime.Now.AddDays(14)),
                new LåneSystem(bøkerList[1], kundeList[1], DateTime.Now, DateTime.Now.AddDays(7)),
                new LåneSystem(bøkerList[2], kundeList[2], DateTime.Now, DateTime.Now.AddDays(21))
            };
            var bibliotek = new BibliotekManagement(kundeList, bøkerList, lånesystem);

            var commands = new Command[]
            {
                new AddBookCommand(bibliotek),
                new AddKundeCommand(bibliotek),
                new RemoveBookCommand(bibliotek),
                new RemoveKundeCommand(bibliotek),
                new ShowKundeListCommand(bibliotek),
                new ShowLåneSystemCommand(bibliotek),
                new ShowBookListCommand(bibliotek),
                new LånBookCommand(bibliotek),
                new UtlånBookCommand(bibliotek),
                new ShowKundeBooksCommand(bibliotek)
            };

            while (true)
            {
                foreach(var command in commands)
                {
                    Console.WriteLine(command.Description);
                }
                var cmdStr = Console.ReadLine();
                var selectedCommand = commands.SingleOrDefault(cmd => cmd.No == cmdStr);
                selectedCommand.Run();
            }
        }
    }
}

//Klasser, innkapsling, arv:

//Lag et enkelt biblioteksystem. Det skal kunne håndtere bøker, brukere og lån. Det skal være mulig å legge til nye bøker
//og brukere, låne ut og returnere bøker, samt få informasjon om hvilke bøker som er utlånt og hvem som har dem. 

//Neste gang snakker vi om oppgaven, og rekatorerer den 
//Videre må vi også gå igjennom debugging