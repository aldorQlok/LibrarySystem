using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Loan
    {
        public Book Book { get; set; }
        public DateTime LoanDate { get; set; }

        public Loan(Book book)
        {
            Book = book;
            LoanDate = DateTime.Now;
        }
    }
}
