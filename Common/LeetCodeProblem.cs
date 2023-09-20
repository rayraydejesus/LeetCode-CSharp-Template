using System;

public abstract class LeetCodeProblem : ILeetCodeProblem
{
	public readonly int key;
	public readonly string title;
	public readonly string url;
	public readonly string description;

	public LeetCodeProblem(int key, string title, string url, string description)
	{
		this.key = key;
		this.title = title;
		this.url = url;
		this.description = description;
	}

	public abstract object parseInput(string input);
	public abstract bool runSolution(object input);
}


