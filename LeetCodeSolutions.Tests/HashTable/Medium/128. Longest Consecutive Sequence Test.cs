using LeetCodeSolutions.Solutions.HashTable.Medium;

namespace LeetCodeSolutions.Tests.HashTable.Medium;

public class Longest_Consecutive_Sequence_Test {
    
    [TestCase(new[]{100,4,200,1,3,2}, 4)]
    [TestCase(new[]{0,3,7,2,5,8,4,6,0,1}, 9)]
    [TestCase(new[]{1,0,1,2}, 3)]
    public void Test(int[] nums, int expectedResult)
    {
        var number = Longest_Consecutive_Sequence.LongestConsecutive(nums);
        
        Assert.That(number, Is.EqualTo(expectedResult));
    }
}