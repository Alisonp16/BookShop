using System;

namespace BookShop
{

    class Program
    {
   

        static void Main(string[] args)
        {
            BookClass[] books = InitializeBookLibary();

            OptionMenu.DisplayMenuOnConsole();
            int option = 0;
            do
            {


                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(option);
                switch (option)
                {
                    case OptionMenu.PrintMenu:
                        OptionMenu.DisplayMenuOnConsole();
                        break;

                    case OptionMenu.PrintBookList:
                        PrintBookList(books);

                        break;


                    case OptionMenu.InsertBook:

                        for (int i = 0; i < books.Length; i++)
                        {
                            BookClass book = new BookClass();
                            book.getUserInput();
                            books[i] = book;
                        }
                        break;


                    case OptionMenu.FindBook:
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

                        break;
                    case OptionMenu.UpdateBook:


                        //book.Update();


                        break;
                    case OptionMenu.Exit:
                        Console.WriteLine("Goodbye");
                        break;
                }
            } while (option != OptionMenu.Exit);
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