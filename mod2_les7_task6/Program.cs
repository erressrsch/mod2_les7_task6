namespace mod2_les7_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height: ");
            int height = int.Parse(Console.ReadLine());

            if (height >= 0 && height < 140)
            {
                Console.WriteLine("You are too small to use keyboard");
            }

                if (height >= 140 && height < 165)
            {
                Console.WriteLine("You are halfling");
            }

            if (height >= 165 && height < 195)
            {
                Console.WriteLine("You are mugol");
            }
            if (height >= 195)
            {
                Console.WriteLine("You are Hagrid");
            }
        }
    }
}
