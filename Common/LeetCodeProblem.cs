using System;
namespace Leetcode_CSharp_Template.Common
{
	public abstract class LeetCodeProblem : ILeetCodeProblem
	{
		public readonly int key;
		public readonly string description;
		public readonly string url;

		public abstract object parseInput(string input);
		public abstract bool runSolution(object input);
	}
}

