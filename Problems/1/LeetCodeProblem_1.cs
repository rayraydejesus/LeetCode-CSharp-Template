﻿public sealed class LeetCodeProblem_1 : LeetCodeProblem
{
	public LeetCodeProblem_1(
        int key = 1,
		string title = "Two Sum",
		string url = "https://leetcode.com/problems/two-sum/",

        string description =
		"Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target." +
		"\n\nYou may assume that each input would have exactly one solution, and you may not use the same element twice." +
		"\n\nYou can return the answer in any order." +
		"\n\n \n\nExample 1:" +
		"\n\nInput: nums = [2,7,11,15], target = 9" +
		"\nOutput: [0,1]" +
		"\nExplanation: Because nums[0] + nums[1] == 9, we return [0, 1]." +
		"\nExample 2:" +
		"\n\nInput: nums = [3,2,4], target = 6" +
		"\nOutput: [1,2]" +
		"\nExample 3:" +
		"\n\nInput: nums = [3,3], target = 6" +
		"\nOutput: [0,1]" +
		"\n \n\nConstraints:" +
		"\n\n2 <= nums.length <= 104" +
		"\n-109 <= nums[i] <= 109" +
		"\n-109 <= target <= 109" +
		"\nOnly one valid answer exists."
	) : base(key, title, url, description) {}

	protected override void retrieveInput()
	{
		while(true)
		{
            base.retrieveInput();
            string input = Console.ReadLine();

			if (input == "")
				Console.WriteLine("No input recieved.");
			else
			{
				int leftBracket = -1;
				int rightBracket = -1;
				int targetEquals = -1;

				// NOTE: Finds the brackets for array substring
				for(int i =  0; i < input.Length; ++i)
				{
					if(input[i] == '[')
						leftBracket = i + 1;
					if (input[i] == ']')
					{
						rightBracket = i - leftBracket;
						break;
					}
				}

				// NOTE: Creates nums string for conversion
				string numsString = input.Substring(leftBracket, rightBracket);
				int[] nums = Array.ConvertAll(numsString.Split(','), int.Parse);
                //Console.WriteLine(numsString);
                //Console.WriteLine("[{0}]", string.Join(", ", nums));


                // NOTE: Creates target string for conversion
                string targetString = input.Substring(leftBracket + rightBracket);
				targetEquals = targetString.IndexOf('=');
				targetString = targetString.Substring(targetEquals + 1).Trim();
                int target = int.Parse(targetString);
				//Console.WriteLine(targetString);
				//Console.WriteLine(target);


            }
        }
    }
	protected override bool runSolution(object input)
	{
		return false;
	}
	protected override void printSolution(object solution)
	{

	}
}


