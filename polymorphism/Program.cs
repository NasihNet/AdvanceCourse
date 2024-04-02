namespace polymorphism
{
    internal class Program
    {   //polymorphism = greek word that means have many forms.
        //Object can be identified by more than one type
        //ex. A dog is also : canine,animal,organism
        static void Main(string[] args)
        {

           car car = new car(3);
            Boat boat = new Boat(2);
            Bicycle bicycle = new Bicycle(5);
           var vehicleList = new List<Vehicle>();

            vehicleList.Add(car);
            vehicleList.Add(boat);
            vehicleList.Add(bicycle);

            foreach (var vehicle in vehicleList)
            {

                vehicle.Go();
            }
            




        }
    }


    public class Vehicle
    {
        public int speed { get; set; }

        public Vehicle(int speed)
        {
            this.speed = speed;
          
        }

        public virtual void Go()
        { 
        
        }

    }


    public class car : Vehicle
    {
        public car(int speed) : base(speed)
        {
          
         
        }

        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Boat : Vehicle
    {
        public Boat(int speed) : base(speed)
        {
        }

        public override void Go()
        {
            Console.WriteLine("boat is moving");
        }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(int speed) : base(speed)
        {
        }

        public override void Go()
        {
            Console.WriteLine("bicycle is moving");
        }
    }





}