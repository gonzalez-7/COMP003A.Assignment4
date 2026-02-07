namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxSteps = 8;
            int restrictedStep = 3;
            int safetyLimit = 6;
            
            //tracks how far the user has progressed
            int currentStep = 0;

            // this loop is because the menu list must repeat until the user exits
            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("1. Start/Continue Routine");
                Console.WriteLine("2. View Progress");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());


            }
        }
    }
}
