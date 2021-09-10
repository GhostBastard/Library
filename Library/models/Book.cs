using System;
using System.Collections.Generic;
using System.Text;

namespace Library.models
{
    class Book
    {
        object[] book = new object[4];

        public Book() { }
        public Book(out object[] book)
        {
            book = this.book;
        }

        public void AddNewBook(int id, string title, string author, int amountOfPages)
        {
            book[0] = id;
            book[1] = title;
            book[2] = author;
            book[3] = amountOfPages;
        }



        public void TakeBook(out object[] arr)
        {
            object[] arr2 = new object[4];
            for (int i = 0; i < book.Length; i++)
                arr2[i] = book[i];
            arr = arr2;

        }

        public void EditBook()
        { }
    }
}
