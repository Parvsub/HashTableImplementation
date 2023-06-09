namespace HashTableImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CustomHashTable<string> myHashTable = new CustomHashTable<string>(10);
            myHashTable.Add("Praveen");
            myHashTable.Add("Mohan");
            myHashTable.Add("Rohith");
            myHashTable.Add("Samyuktha");

            myHashTable.Display();

            myHashTable.Search("Mohan");
            myHashTable.Search("Samyuktha");

            myHashTable.Delete("Samyuktha");

            myHashTable.Display();
        }
    }
}