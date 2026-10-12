using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.LibraryManagementConsoleApp
{
    public class BorrowerService
    {
        public static List<BorrowerDto> borrowers = new List<BorrowerDto>();
        public void CreateBorrower(string no, string name, long phoneNo)
        {
            int maxId = borrowers.Count == 0 ? 0 : borrowers.Max(x => x.BorrowerId);
            BorrowerDto borrower = new BorrowerDto
            {
                BorrowerId= maxId + 1,
                No = no,
                Name = name,
                PhoneNo = phoneNo
            };
            borrowers.Add(borrower);
        }

        public void ShowBorrowers()
        {
            foreach (var borrower in borrowers)
            {
                Console.WriteLine($"BorrowerId: {borrower.BorrowerId}, No: {borrower.No}, Name: {borrower.Name}, PhoneNo: {borrower.PhoneNo}");
            }
        }
    }
}
