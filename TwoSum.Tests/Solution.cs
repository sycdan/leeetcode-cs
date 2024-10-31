namespace TwoSum.Tests;

public class Solution
{
	/// <summary>
	/// O(n2) solution.
	/// </summary>
	/// <param name="nums"></param>
	/// <param name="target"></param>
	/// <returns></returns>
	public int[] TwoSumBasic(int[] nums, int target)
	{
		for (var i = 0; i < nums.Length; i++)
		{
			for (var j = i + 1; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == target)
				{
					return [i, j];
				}
			}
		}
		return [];
	}

	/// <summary>
	/// Optimized solution to find two numbers that sum to a given target.
	/// </summary>
	/// <param name="nums">The number pool.</param>
	/// <param name="target">The target number to get by adding two from the pool.</param>
	/// <returns>The indices of the two numbers that sum to the target.</returns>
	public int[] TwoSum(int[] nums, int target)
	{
		var needs = new Dictionary<int, int>();

		// For every number, figure out how much we need to add to it to get to the target.
		for (var i = 0; i < nums.Length; i++)
		{
			var have = nums[i];

			// If we have a number that meets a previous need, then we know the solution.
			if (needs.TryGetValue(have, out int needIndex))
			{
				return [needIndex, i];
			}

			// If not, store the need along with the current index, so we can find it quickly later.
			// Don't bother checking if it's already there; if there are duplicates we can just keep the last one.
			needs[target - have] = i;
		}
		return [];
	}
}
