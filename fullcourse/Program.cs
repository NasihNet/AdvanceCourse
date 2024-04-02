namespace fullcourse
{
    internal class Program
    {   //static
        //inheritence
        //abstract class = modifier that indicates missing components or incomplete implementation.
        static void Main(string[] args)
        {
            
        }
    }


    public class Car
    {
        //static = modifier to declare a static memberm which belongs to the class itself rather
        //than to any specific object

        public static int TotalProject { get; set; }

        public int  GetTotalProject()
        { 
           return TotalProject; 
        }


        public void AddProject()
        {
            TotalProject++;
           
        }

        public static void StartRace()
        { 
        
            
        }

    }
}