using System;

namespace BookShop
{
    class OptionMenu
    {
        /*
         * 
         * centralizing menu codes and settings in one place
         * */
        public const int Exit = 0; 
        public const int PrintBookList = 1;
        public const int InsertBook = 2;
        public const int UpdateBook = 3;
        public const int FindBook = 4;
        public const int PrintMenu = 5;

        public static void DisplayMenuOnConsole()
        {
            Console.WriteLine($"{InsertBook}. Add the book.");//${} prints a variable into a string
            Console.WriteLine($"{PrintBookList}. Print book details.");
            Console.WriteLine($"{UpdateBook}. Update the book details by ISBN.");
            Console.WriteLine($"{FindBook}. Please enter the ISBN number to be deleted.");
            Console.WriteLine($"{PrintMenu}. Print The Menu.");
            Console.WriteLine($"{Exit}. Exit Application.");
        }
    }
}
