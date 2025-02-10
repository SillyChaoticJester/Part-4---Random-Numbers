namespace Part_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int number = generator.Next(); //Random Number from 0-MaxInt
            int numberTwo = generator.Next(10); //Random Number from 0-9, does NOT add the number in the brackets
            int numberThree = generator.Next(5, 10); //Random Number from 5-9, max number doesn't get added to the list
        }
    }
}
