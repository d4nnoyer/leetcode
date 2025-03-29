namespace LeetCodeSolutions.Tests.Array.Easy;

internal class Can_Place_Flowers_Test {
    
    [TestCase(new[]{1,0,0,0,1}, 1, true)]
    [TestCase(new[]{1,0,0,0,1}, 2, false)]
    [TestCase(new[]{1,0,0}, 1, true)]
    [TestCase(new[]{0,0,1}, 1, true)]
    [TestCase(new[]{0,0,0}, 2, true)]
    [TestCase(new[]{1,0,1}, 1, false)]
    [TestCase(new[]{0,1,0}, 1, false)]
    public void Test(int[] nums, int value, bool expected)
    {
        var canPlant = Can_Place_Flowers.CanPlaceFlowers(nums, value);
        
        Assert.That(canPlant, Is.EqualTo(expected));
    }   
}