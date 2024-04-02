namespace Enums
{
    internal class Program
    {   //special class that contains a set of named integer constants.
        //User Enums when you have values that you know will not change,
        //To get the integer value from an item, you must explicitly conert to an int
        static void Main(string[] args)
        {
            Console.WriteLine(PlanetsRadius.Saturn);
            Console.WriteLine((int)PlanetsRadius.Saturn);
        }
    }

    public enum Planets
    { 
       Mercury,
       Venus,
       Mars,
       Jupiter,
       Saturn
    
    }

    public enum PlanetsRadius
    {

        Mercury = 123123,
        Venus = 934785,
        Mars = 85478,
        Jupiter= 348975,
        Saturn = 09345



    }
}