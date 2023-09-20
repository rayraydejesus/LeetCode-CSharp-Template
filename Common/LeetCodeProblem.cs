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

	public virtual void printProblem()
	{
		Console.WriteLine(this.key + ". " + this.title);
		Console.WriteLine(this.description);
	}

	public abstract void retrieveInput();
	public abstract bool runSolution(object input);
	public abstract void printSolution(object solution);
}


