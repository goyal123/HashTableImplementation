namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str;
            Console.WriteLine("Welcome to the hashing");
            CustomHashTable Mylist = new CustomHashTable();
            str = Console.ReadLine().Trim().Split(" ");

            foreach (string data in str)
                Mylist.AddLast(data);

            Mylist.display();
            Console.WriteLine("Enter the word you want to remove");
            var choice=Console.ReadLine();
            Mylist.Remove(choice);
            Mylist.display();


        }
    }
}