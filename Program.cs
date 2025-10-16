namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Interview with The Vampire";
            book1.Author = "Anne Rice";

            Book book2 = new Book();
            book2.Title = "Game Of Thrones";
            book2.Author = "George R. R Martin";


            User firstuser = new User();
            firstuser.Name = "Aldor";
            firstuser.Loans = new List<Loan>();

            firstuser.BorrowBook(book1);
            firstuser.BorrowBook(book2);


            foreach (var book in firstuser.Loans)
            {
                Console.WriteLine(book.Book.Title);
            }
        }
    }
}
