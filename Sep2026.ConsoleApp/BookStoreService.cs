using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.ConsoleApp
{
    public class BookStoreService
    {
        public static List<BookDto> bookStores = new List<BookDto>();

        public void CreateBookStore(string bookNo, string bookTitle,  string author)
        {
            //BorrowerDto item = BorrowerService.borrowers.Where(x => x.No == borrowerNo).FirstOrDefault();
            int maxId = bookStores.Count == 0 ? 0 : bookStores.Max(x => x.BookId);
            BookDto bookStore = new BookDto
            {
                BookId = maxId + 1,
                BookNo = bookNo,    
                BookTitle = bookTitle,
                Author = author,
                //Quantity = quantity,
                //AvailableQuantity = availableQuantity
            };
            bookStores.Add(bookStore);
       
        }

    public void ShowBookStores()
        {
            foreach (var bookStore in bookStores)
            {
                Console.WriteLine($"BookId: {bookStore.BookId}, BookNo: {bookStore.BookNo}, BookTitle: {bookStore.BookTitle}, Author: {bookStore.Author}");
            }
        }
    }
}
