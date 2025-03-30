using LeetCodeSolutions.Solutions.Array.Hard;

namespace LeetCodeSolutions.Tests.Array.Hard;

internal class CandyTest {
    
    [TestCase(new[]{1,0,2},  5)]
    [TestCase(new[]{1,2,2},  4)]
    [TestCase(new[]{1,3,2,2,1},  7)]
    [TestCase(new[]{1,3,4,5,2},  11)]
    [TestCase(new[]{29,51,87,87,72,12},  12)]
    [TestCase(new[]{1},  1)]
    public void Test(int[] ratings, int expectedResult)
    {
        var candies = Candy.GetCandy(ratings);
        
        Assert.That(candies, Is.EqualTo(expectedResult));
    }
}