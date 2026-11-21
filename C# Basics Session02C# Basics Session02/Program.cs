using System.Drawing;
using System.Text;

namespace C__Basics_Session02C__Basics_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q!
            //string title = "clean code";
            //string uppertitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(uppertitle);
            #endregion
            #region Q2
            //string fliter = "clean code";
            //string sliter = "clean code";
            //Console.WriteLine(object.ReferenceEquals(fliter, sliter));
            #endregion
            #region Q3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            //StringBuilder sb = new StringBuilder();
            //sb.Append(book list");
            //sb.Append("_updated");
            //Console.WriteLine(sb);
            #endregion
            #region Q4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            //StringBuilder sb = new StringBuilder();
            //sb.Append("book list");
            //sb.Append("_update");
            //sb.Replace("book list", "Library");
            //Console.WriteLine(sb);
            #endregion
            #region Q5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            // Pages: 464" using the + operator
            //string title = "clean code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + " , Pages: " + pages);
            #endregion
            #region Q6
            // Build the same sentence as above, but using string interpolation ($"...").
            //string title = "clean code";
            //int pages = 464;
            //string interpolatioh=$"Book: {title} , pages : {pages}.";
            //Console.WriteLine(interpolatioh);
            #endregion
            #region Q7
            //Build the same sentence again, but using string.Format().
            //string title = "clean code";
            //int pages = 464;
            //string format =string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(format);
            #endregion
            #region Q8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //300, otherwise prints "Short Book".
            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion
            #region Q9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            
            
            #endregion
        }
    }
}
