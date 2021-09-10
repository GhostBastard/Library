using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Department department = new Department();
            book.AddNewBook(1,"qwer","qwe",100);
            department.AddBook();

            Console.ReadKey();
        }
    }
}
