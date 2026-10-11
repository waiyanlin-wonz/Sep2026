// See https://aka.ms/new-console-template for more information
using Sep2026.ConsoleApp;

Start:
Console.WriteLine("This is a library Management System");
Console.WriteLine("1. Create Book");
Console.WriteLine("2. Create Borrower");
Console.WriteLine("3. Borrowing Book");
Console.WriteLine("4. Returning Book");
Console.WriteLine("5. Exit");

Console.Write("Please select an option : ");
string option = Console.ReadLine();

switch (option)
{
    case "1":
        AddBook();
        break;

    case "2":
        AddBorrower();
        break;

    case "3":
        BorrowBook();
        break;
    case "4":
        ReturnBook();
        break;
    case "5":
        goto End;
    default:
        break;
}

static void AddBook()
{
    Console.WriteLine("Enter Book No:");
    string bookNo = Console.ReadLine();
    Console.WriteLine("Enter Book Title:");
    string bookTitle = Console.ReadLine();
    Console.WriteLine("Enter Author Name:");
    string author = Console.ReadLine();
    BookStoreService bookStoreService = new BookStoreService();
    bookStoreService.CreateBookStore(bookNo,bookTitle, author);
    bookStoreService.ShowBookStores();
    Console.WriteLine("Book added successfully.");
}

static void AddBorrower()
{
    Console.WriteLine("Enter borrower No:");
    string no = Console.ReadLine();
    Console.WriteLine("Enter borrower Name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter borrower Phone No:");
    long phoneNo = long.Parse(Console.ReadLine());
    BorrowerService borrowerService = new BorrowerService();
    borrowerService.CreateBorrower(no, name, phoneNo);
    borrowerService.ShowBorrowers();

}

static void BorrowBook()
{
    Console.WriteLine("Enter Book No:");
    string bookNo = Console.ReadLine();
    Console.WriteLine("Enter Borrower No:");
    string borrowerNo = Console.ReadLine();
    BorrowingService borrowingService = new BorrowingService();
    borrowingService.borrowing(bookNo, borrowerNo);
    borrowingService.ShowBorrowings();
}

static void ReturnBook()
{
    Console.WriteLine("Enter Book No:");
    string bookNo = Console.ReadLine();
    Console.WriteLine("Enter Borrower No:");
    string borrowerNo = Console.ReadLine();
    BorrowingService borrowingService = new BorrowingService();
    borrowingService.Returning(bookNo, borrowerNo);
    borrowingService.ShowBorrowings();

}

goto Start;
Console.ReadLine();
End:
Console.WriteLine("Exiting app...");