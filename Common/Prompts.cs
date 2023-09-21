using System;

public static class Prompts
{
	public static bool oneMoreTime(string text = "Would you like to another problem?")
	{
        Console.WriteLine(text +" (Y/N)");
        string input = Console.ReadLine().ToLower();

        if (input.Length < 1)
            return false;
        else if (input[0] == 'y')
            return true;
        else
            return false;
    }

    public static bool anotherSolution()
    {
        return oneMoreTime("Would you like to try another solution?");
    }
}


