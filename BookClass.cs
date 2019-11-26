namespace BookShop
{
    using System;
    class BookClass
    {

        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public BookClass() { }
        public BookClass(string isbn, string author, string title, double price)
        {
            this.ISBN = isbn;
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        public void getUserInput()
        {
            try
            {
                Console.WriteLine("Please enter the ISBN number   ");
                ISBN = Console.ReadLine();
                Console.WriteLine("Enter the Author");
                Author = Console.ReadLine();
                Console.WriteLine("enter the title");
                Title = Console.ReadLine();
                Console.WriteLine("enter the price now please");
                Price = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Price must be Numeric");
            }
            Console.ReadLine();
        }
    }
}