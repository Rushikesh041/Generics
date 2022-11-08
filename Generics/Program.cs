namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compare<int> maximumInt = new Compare<int>(20, 30, 40, 50);
            Console.WriteLine("Largest Number is : " + maximumInt.MaxMethod());
            Compare<float> maximumFloat = new Compare<float>(30.10f, 50.95f, 10.50f, 70.68f);
            Console.WriteLine("Largest Number is : " + maximumFloat.MaxMethod());
            Compare<string> maximumString = new Compare<string>("40", "60","80", "90");
            Console.WriteLine("Largest String is : " + maximumString.MaxMethod());
        }
    }
}