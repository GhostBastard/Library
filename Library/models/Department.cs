using System;
using System.Collections.Generic;
using System.Text;

namespace Library.models
{
    class Department
    {
        List<object[]> listOfBooks = new List<object[]>();
        object[] book = new object[4];

        public void AddBook()
        {
            Book instanceOfBook = new Book(out object[] book);
            instanceOfBook.TakeBook(out book);
            listOfBooks.Add(book);
            Console.WriteLine(listOfBooks[0]);
        }
    }
}
