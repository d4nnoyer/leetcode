using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions.Tests;

public class Count_Symmetric_Integers_Test {
    
    [TestCase(1, 100, 9)]
    [TestCase(1200, 1230, 4)]
    public void Test(int low, int high, int expectedResult) 
    {
        var result = Count_Symmetric_Integers.CountSymmetricIntegers(low, high);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}