
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the leetcode console app!");

        string input = "";
        int response = -1;
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("Please input the number of the question you'd like to see.");
            input = Console.ReadLine();

            if(int.TryParse(input, out response))
            {
                Console.Clear();
                LeetCodeProblem_1 problem = new LeetCodeProblem_1();
                problem.printProblem();
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
