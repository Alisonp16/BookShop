using System;

namespace BookShop
{

    class Program
    {


        static void Main(string[] args)
        {
            BookClass[] books = InitializeBookLibary();
                        string isbnInput = "";
            OptionMenu.DisplayMenuOnConsole();
            int option = 0;
            do
            {
                Console.WriteLine("Enter Menu Option");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case OptionMenu.PrintMenu:
                        OptionMenu.DisplayMenuOnConsole();
                        break;

                    case OptionMenu.PrintBookList:
                        PrintBookList(books);
                        break;
                    case OptionMenu.InsertBook:
                        InsertBooks(books);
                        break;


                    case OptionMenu.FindBook:
                        
                        findbook(books, isbnInput);

                        break;
                    case OptionMenu.UpdateBook:

                        BookClass book = findbook(books, isbnInput);

                        updatebook(book);
                        //book.Update();


                        break;
                    case OptionMenu.Exit:
                        Console.WriteLine("Goodbye");
                        break;
                }
            } while (option != OptionMenu.Exit);
        }

        private static void updatebook(BookClass book)
        {
            book.getUserInput();
        }

        private static BookClass findbook(BookClass[] books, string isbn)
        {
            foreach (BookClass book in books)
            {
                try
                {
                    //if (book.ISBN.Equals(IS))
                    {

                        //book.Search(search);
                        Console.WriteLine("THIS ISBN DOES NOT EXIST");
                        {

                        }
                    }
                }
                catch
                {

                }
            }
            //
            //function not working.returning a blank book to allow the update function to work
            //
            return new BookClass();
        }

        private static void InsertBooks(BookClass[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"input book {i}");
                books[i].getUserInput();
            }
        }

        private static BookClass[] InitializeBookLibary()
        {
            BookClass[] list = new BookClass[4];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new BookClass();
            }


            return list;
        }

        private static void PrintBookList(BookClass[] books)
        {
            foreach (BookClass book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}