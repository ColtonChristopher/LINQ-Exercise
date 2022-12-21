namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] VideoGameTitle = { "Apex Legends", "Overwatch", "God of War", "Doom" };
            var videogame = from color in VideoGameTitle
                            where color.Length <= 13
                            orderby color.Length
                             select color;

            foreach (string x in videogame)
                Console.WriteLine(x);

            

        }
    }
}
