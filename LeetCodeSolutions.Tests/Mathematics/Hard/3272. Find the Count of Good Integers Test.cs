using LeetCodeSolutions.Solutions.Mathematics.Hard;

namespace LeetCodeSolutions.Tests.Mathematics.Hard;

public class Find_the_Count_of_Good_Integers_Test {
    
    [TestCase(3, 5, 27)]
    [TestCase(1, 4, 2)]
    [TestCase(5, 6, 2468)]
    public void Test(int n, int k, int expectedResult) 
    {
        var result = Find_the_Count_of_Good_Integers.CountGoodIntegers(n, k);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}