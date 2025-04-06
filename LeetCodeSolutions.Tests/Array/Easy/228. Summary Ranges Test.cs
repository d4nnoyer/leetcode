namespace LeetCodeSolutions.Tests.Array.Easy;

public class Summary_Ranges_Test {
    
    [TestCase(new[]{0,1,2,4,5,7}, new[]{"0->2","4->5","7"})]
    [TestCase(new[]{0,2,3,4,6,8,9}, new[]{"0","2->4","6","8->9"})]
    public void Test(int[] nums, IList<string> expectedResult)
    {
        var result = Summary_Ranges.SummaryRanges(nums);
            
        Assert.That(result, Is.EqualTo(expectedResult));
    }   
}