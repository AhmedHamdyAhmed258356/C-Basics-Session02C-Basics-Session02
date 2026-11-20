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
            StringBuilder sb = new StringBuilder();
            sb.Append("clean code");
            sb.Append("_updated");
            Console.WriteLine(sb);
            #endregion
        }
    }
}
