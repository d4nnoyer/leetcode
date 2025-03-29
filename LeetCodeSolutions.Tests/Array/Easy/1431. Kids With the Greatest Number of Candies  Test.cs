namespace LeetCodeSolutions.Tests.Array.Easy;

internal class Kids_With_the_Greatest_Number_of_Candies__Test {
    
    [TestCase(new[]{2,3,5,1,3}, 3,   new[]{true,true,true,false,true})]
    [TestCase(new[]{4,2,1,1,2}, 1,   new[]{true,false,false,false,false})]
    [TestCase(new[]{12,1,12}, 10,   new[]{true,false,true})]
    public void Test(int[] candies, int extraCandies, bool[] expected)
    {
        var result = Kids_With_the_Greatest_Number_of_Candies.KidsWithCandies(candies, extraCandies);
                
        Assert.That(result, Is.EqualTo(expected));
    }

}