using LeetCodeSolutions.Solutions.BitManipulation.Medium;

namespace LeetCodeSolutions.Tests.BitManipulation.Medium;

public class Single_Number_II_Test {
    
    [TestCase(new[]{2,2,3,2}, 3)]
    [TestCase(new[]{0,1,0,1,0,1,99}, 99)]
    public void Test(int[] numbers, int expected) 
    {
        var singleNumber = Single_Number_II.SingleNumber(numbers);
        Assert.That(singleNumber, Is.EqualTo(expected));
    }
}