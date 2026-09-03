using System.Diagnostics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion

            #region Question 2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question 3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            PrintWelcomeMessage();
            #endregion

            #region Question 4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".
            PrintBookTitle("Clean Code");
            #endregion

            #region Question 5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
                        int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            Console.WriteLine("print 400  because the AddBonusPages method  calls by value, that copies the value and works on the copy");
            #endregion

            #region Question 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            double[] prices2 = { 25.5, 40.0 };
            ApplyDiscount(prices2);
            Console.WriteLine(prices2[0]);
            Console.WriteLine("print 20.5 because the ApplyDiscount method calls refrence type by value that copies the reference and works it so it changes the original array");
            #endregion

            #region Question 7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            int pages3 = 400;
            AddBonusPagesByRef(ref pages3);
            Console.WriteLine(pages3);
            Console.WriteLine("print 450 because the AddBonusPagesByRef method calls by reference, that works on the original value");
            #endregion

            #region Question 8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward.
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);
            #endregion

            #region Question 9
            //Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //and print the price if found
            double price = 0;
            TryGetPrice("Clean Code", out price);
            Console.WriteLine(price);
            #endregion


        }
        #region Question 3
        //Write a method called PrintWelcomeMessage that takes no parameters and prints
        //"Welcome to the Library!".Call it from Main.
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion

        #region Question 4
        //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
        //"Clean Code".
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        #endregion

        #region Question 5
        //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
        //int pages = 400; and print pages afterward.What do you expect to see, and why?
        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion

        #region Question 6
        //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
        //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
       // see, and why?
       public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion

        #region Question 7
        //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
        //Call it and print pages afterward.How is the result different from question 5?
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion

        #region Question 8
        //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
       // new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
       //afterward.
       public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region Question 9
        //Write a method bool TryGetPrice(string title, out double price) that returns true and sets
        //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
        //and print the price if found
        public static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        #endregion
    }
}
