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
            StringBuilder sb = new StringBuilder();
            sb.Append("book list");
            sb.Append("_update");
            sb.Replace("book list", "Library");
            Console.WriteLine(sb);
            #endregion
        }
    }
}
