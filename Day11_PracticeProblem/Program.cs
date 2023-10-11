namespace Day11_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any program");
            Console.WriteLine("1. Remaining Chapter Count\n" +
                "2. Maximaum selling price");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Remaining_Chaptercs.RemainingChepters();
                    break;
                case 2:
                    Max_Selling_Price.MaximumSellingPriceBySwapping();
                    break;

                default:
                    Console.WriteLine("Invalid use case number");
                    break;
            }
            Console.ReadLine();
        }
    }
}