using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class User
    {
        public string Name { get; set; }

        public List<Loan> Loans { get; set; } = new List<Loan>();

        public void BorrowBook(Book book)
        {
            Loan newLoan = new Loan(book);
            Loans.Add(newLoan);
            Console.WriteLine($"{Name} lånade {book.Title} Elvira");
        }
    }
}
