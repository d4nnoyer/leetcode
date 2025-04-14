namespace LeetCodeSolutions.Tests.Array.Easy;

public class Count_Good_Triplets_Test {
    
    [TestCase(new[]{3,0,1,1,9,7}, 7, 2, 3, 4)]
    [TestCase(new[]{1,1,2,2,3}, 0, 0, 1, 0)]
    public void Test(int[] arr, int a, int b, int c, int expectedResult)
    {
        var result = Count_Good_Triplets.CountGoodTriplets(arr, a, b, c);
                
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}