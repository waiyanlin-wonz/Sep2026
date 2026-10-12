using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.LibraryManagementConsoleApp
{
    public class BorrowingDto
    {
        public int BorrowingId { get; set; }
        public string BookNo { get; set; }
        public string BorrowerNo { get; set; }
        public DateTime BorrowDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
