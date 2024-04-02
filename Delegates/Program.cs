namespace Delegates
{
    delegate void LogDel(string text);
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var logDel = new LogDel(LogText);

            var name = Console.ReadLine();

            logDel(name);

        }

        static void LogText(string text)
        {
            Console.WriteLine("{0} : {1}",DateTime.Now,text);
        }
    }
}