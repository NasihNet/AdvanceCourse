using System.Reflection.Metadata.Ecma335;

namespace Generic
{
    internal class Program
    {       //Generic = not specific to  a particular data type
            //add <T> to : class,methods,field etc
            //allow for code reusability for a different data type
        static void Main(string[] args)
        {
            int[] intArray = { 1,2,3};
            string[] stringArray = { "1", "2", "3" };

            displayElement(intArray);
            displayElement(stringArray);

            var data = new DataStore<int>();


        }

        public static void displayElement<T>(T[] arrayElement)
        { 
        
            foreach (T element in arrayElement) {
                Console.WriteLine(element);
            }
        }
    }

    class DataStore<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }
}