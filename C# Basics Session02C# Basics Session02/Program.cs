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
            string fliter = "clean code";
            string sliter = "clean code";
            Console.WriteLine(object.ReferenceEquals(fliter, sliter));
            #endregion
        }
    }
}
