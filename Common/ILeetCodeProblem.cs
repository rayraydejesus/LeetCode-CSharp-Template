using System;
namespace Leetcode_CSharp_Template.Common
{
	public interface ILeetCodeProblem
	{
		public object parseInput(string input);
		public bool runSolution(object input);
	}
}

