
namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to \n see the multiplaction table: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i + " x " + num + " = " + (i * num));
        }
    }
}
