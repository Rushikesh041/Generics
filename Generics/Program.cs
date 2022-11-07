namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number is largest :  " + compare.Largest(60, 50, 20));

            Console.WriteLine("Third number is largest :  " + compare.Largest(40, 30, 60));

            Console.WriteLine("Second number is largest :  " + compare.Largest(40, 60, 20));

            Console.WriteLine("largest number is  :  " + compare.Largest(60.2f, 70.5f, 30.3f));
        }
    }
}