
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the leetcode console app!");

        string input = "";
        int key = -1;
        
        while(true)
        {
            Console.WriteLine("Please input the number of the question you'd like to see.");
            input = Console.ReadLine();

            if(int.TryParse(input, out key))
            {
                Console.Clear();
                ILeetCodeProblem problem = ProblemsIndex.retrieveProblem(key);

                if (problem == null)
                    Console.WriteLine("Problem " + key + " is currently unavailible.");
                else
                    problem.runProblem();
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }


            Console.WriteLine("Would you like to try again? (Y/N)");
            input = Console.ReadLine().ToLower();

            if (input.Length < 1)
                break;
            else if (input[0] == 'y')
                continue;
            else
                break;
        }

        Console.WriteLine("Goodbye!");
    }
}
