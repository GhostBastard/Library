using Library.models;
using System;

namespace Library
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Department dep = new Department();
            Book book = new Book();
            Console.WriteLine("1 - добавить книгу \n2 - редактировать книгу \n3 - добавить отдел \n4 - редактировать отдел \n5 - добавить заведующего \n6 - поменять заведующего");
            int choise;
            choise = Convert.ToInt32(Console.Read());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Введите данные книги (id, название, автора, кол-во страниц): ");
                    int id = Convert.ToInt32(Console.Read());
                    string title = Convert.ToString(Console.Read());
                    string author = Convert.ToString(Console.Read());
                    int amountOfPages = Convert.ToInt32(Console.Read());
                    book.AddNewBook(id, title, author, amountOfPages);
                    dep.AddBook();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
                












            //Book book = new Book();
            //Department department = new Department();
            //book.AddNewBook(1,"qwer","qwe",100);
            //department.AddBook();

            Console.ReadKey();
        }
    }
}
