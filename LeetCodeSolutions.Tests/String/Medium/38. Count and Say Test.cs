using LeetCodeSolutions.Solutions.String.Medium;

namespace LeetCodeSolutions.Tests.String.Medium;

public class Count_and_Say_Test {
    
    [TestCase(1, "1")]
    [TestCase(2, "11")]
    [TestCase(3, "21")]
    [TestCase(4, "1211")]
    public void Test(int n, string expectedResult) 
    {
        var result = Count_and_Say.CountAndSay(n);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}