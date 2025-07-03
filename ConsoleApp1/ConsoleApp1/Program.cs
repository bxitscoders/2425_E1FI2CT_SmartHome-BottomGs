namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string erg = string.Format("{0:C}", 20.4) + '€';
            Console.WriteLine(erg);
        }
    }
}
