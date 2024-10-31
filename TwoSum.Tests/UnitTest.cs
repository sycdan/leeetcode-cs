namespace TwoSum.Tests;

public class UnitTest
{
	[Theory]
	// Public
	[InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
	[InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
	[InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
	// Mine
	[InlineData(new int[] { 3, 3, 27, 12, 23, 56, 9, 11, 34 }, 32, new int[] { 4, 6 })]
	[InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
	public void Test1(int[] nums, int target, int[] output)
	{
		var solution = new Solution();
		Assert.Equal(output, solution.TwoSumBasic(nums, target));
		Assert.Equal(output, solution.TwoSum(nums, target));
	}
}
