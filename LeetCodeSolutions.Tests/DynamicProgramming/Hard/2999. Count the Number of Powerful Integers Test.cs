using LeetCodeSolutions.Solutions.DynamicProgramming.Hard;

namespace LeetCodeSolutions.Tests.DynamicProgramming.Hard;

public class Count_the_Number_of_Powerful_Integers_Test {
    
    [TestCase(1, 6000, 4, "124", 5)]
    [TestCase(15, 215, 6, "10", 2)]
    [TestCase(1000, 2000, 4, "3000", 0)]
    public void Test(long start, long finish, int limit, string s, int expectedResult)
    {
        var result = Count_the_Number_of_Powerful_Integers.NumberOfPowerfulInt(start, finish, limit, s);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}