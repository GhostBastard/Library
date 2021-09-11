using Library.models;
using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - добавить книгу \n 2 - редактировать книгу \n 3 - добавить отдел \n 4 - редактировать отдел \n 5 - добавить заведующего \n 6 - поменять заведующего");
            int choise;
            choise = Convert.ToInt16(Console.Read());













            Book book = new Book();
            Department department = new Department();
            book.AddNewBook(1,"qwer","qwe",100);
            department.AddBook();

            Console.ReadKey();
        }
    }
}
