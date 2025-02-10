namespace Part_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int number = generator.Next(); 
            int numberTwo = generator.Next(10);
            int numberThree = generator.Next(5, 10);

            Console.WriteLine(number);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);

            //Next() = Produces a random number from 0 to the max number put into an integer w/o negatives
            //Next(Int32) = Produces a random number from 0 to one less of the specified integer w/o negatives
            //Next(Int32, Int32) = Produces a random number from within that specific range w/o negatives
            //Next(Double) = Produces a random number from > 0.0 to < 1.0
        }
    }
}
