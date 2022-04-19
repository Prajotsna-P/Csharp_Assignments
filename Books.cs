    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Books_info
    {
/* Structure struct Books creation*/
        struct Books
        {
            public enum bookType
            {
                Magazine, Novel, ReferenceBook, Miscellaneous
            }

            private string _Title;
            private int _price;
            private int _bookId;
            private bookType _bookType;

//Using properties get and set
            public string Title { get; set; }

            public int Price { get; set; }
            public int BookId { get; set; }
            public bookType BookType { get; set; }

        }
        //Getting the inputs
        class BookStructureAndEnum
        {
            public static void Main()
            {
                Books book = new Books();

                Console.WriteLine("Enter Book Id :");
                book.BookId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Book Title:");
                book.Title = (Console.ReadLine());

                Console.WriteLine("Enter Book Price:");
                book.Price = Convert.ToInt32(Console.ReadLine());



                book.BookType = Books.bookType.Magazine;
               //Printing the outputs
                Console.WriteLine("The Book ID :" + book.BookId);
                Console.WriteLine("The Book Title:" + book.Title);
                Console.WriteLine("The Book Price:" + book.Price);
                Console.WriteLine("The Book BookType:" + book.BookType);
            }
        }
    }

