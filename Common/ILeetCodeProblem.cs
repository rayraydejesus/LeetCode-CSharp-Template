using System;

public interface ILeetCodeProblem
{
	public object parseInput(string input);
	public bool runSolution(object input);
}


