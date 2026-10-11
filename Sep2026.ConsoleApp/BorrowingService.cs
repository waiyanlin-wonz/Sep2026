using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.ConsoleApp
{
    public class BorrowingService
    {
        public static List<BorrowingDto> borrowings = new List<BorrowingDto>();
        public void borrowing(string bookNo, string borrowerNo )
        {
            // Check if the book exists in the BookStoreService
            BookDto book = BookStoreService.bookStores.Where(x => x.BookNo== bookNo).FirstOrDefault(); 
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            // Check if the borrower exists in the BorrowerService
            BorrowerDto borrower = BorrowerService.borrowers.Where(x => x.No == borrowerNo).FirstOrDefault();
            if (borrower == null)
            {
                Console.WriteLine("Borrower not found. Please register");
                return;
            }

            int maxId = borrowings.Count == 0 ? 0 : borrowings.Max(x => x.BorrowingId);
            BorrowingDto borrowing = new BorrowingDto
            {
                BorrowingId = maxId + 1,
                BookNo = book.BookNo,
                BorrowerNo = borrower.No,
                BorrowDate = DateTime.Now,
                IsReturned = false
            };
            borrowings.Add(borrowing);
            Console.WriteLine("Book borrowed successfully.");
        } 
        public void Returning(string bookNo, string borrowerNo)
        {
            // Check if the book exists and filter only false IsReturned
            BorrowingDto borrowing = borrowings.Where(x => x.BookNo == bookNo && x.BorrowerNo == borrowerNo && !x.IsReturned).FirstOrDefault();
            if (borrowing == null)
            {
                Console.WriteLine("Borrowing record not found.");
                return;
            }
            borrowing.IsReturned = true;
            Console.WriteLine("Book returned successfully.");
        }
        public void ShowBorrowings()
        {
            foreach (var borrowed in borrowings)
            {
                Console.WriteLine($"BorrowingId: {borrowed.BorrowingId}, BookNo: {borrowed.BookNo}, BorrowerNo: {borrowed.BorrowerNo}, BorrowDate: {borrowed.BorrowDate}, IsReturned: {borrowed.IsReturned}");
            }
        }
    }
}
