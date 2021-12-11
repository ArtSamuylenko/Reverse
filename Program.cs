namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str_2 = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine(str_2);
            Console.ReadLine();
        }
    }
}