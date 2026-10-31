using EF_core1.Data;

namespace EF_core1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BookstoreContext db = new BookstoreContext())
            {
                if (db.Database.EnsureCreated())
                {
                    Console.WriteLine("Database created successfully.");
                }
                else
                {
                    Console.WriteLine("Database already exists.");
                }

                Console.WriteLine("Database: ReadMoreBooksDB");
                Console.WriteLine("Books table: " + db.Books.Count() + " records");
                Console.WriteLine("Authors table: " + db.Authors.Count() + " records");
                Console.WriteLine("Categories table: " + db.Categories.Count() + " records");
            }
        }
    }
}
