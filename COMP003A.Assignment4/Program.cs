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

                if (choice == 1)
                {
                    // blocks the exists to advance the routine one step a time
                    if (currentStep >= maxSteps)
                    {
                        Console.WriteLine("Routine is already complete. No more steps can be done");
                    }

                    else
                    {
                        // moves to the next step
                        currentStep++;

                        // Restricted steps must be skipped
                        if (currentStep == restrictedStep)
                        {
                            Console.WriteLine($"Step {currentStep} is restricted and was skipped");
                            continue;
                        }

                        // Safety limit must stop the routine when reached
                        if (currentStep >= safetyLimit)
                        {
                            Console.WriteLine("Safety limit reached. Routine stopped");
                            break;
                        }

                        Console.WriteLine($"Routine step {currentStep} completed");


                        // Auto-stop once maximum is reached 
                        if (currentStep >= maxSteps)
                        {
                            Console.WriteLine("Maximum steps reached. Routine complete");
                        }
                    }
                }

                else if (choice == 2)
                {
                    // This blocks exists to show progress without changing the routine
                    Console.WriteLine($"Curent progress: {currentStep} steps completed");
                }

                else if (choice == 3)
                {
                    // Exits cleanly by ending the menu loop
                    running = false;
                    Console.WriteLine("Program ended.");
                }
            }
        }
    }
}
