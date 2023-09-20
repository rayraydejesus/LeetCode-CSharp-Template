using System;

public interface ILeetCodeProblem
{
	public void printProblem();
	public void retrieveInput();
	public bool runSolution(object input);
	public void printSolution(object solution);
}


