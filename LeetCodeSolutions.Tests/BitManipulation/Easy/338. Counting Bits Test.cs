using LeetCodeSolutions.Solutions.BitManipulation.Easy;

namespace LeetCodeSolutions.Tests.BitManipulation.Easy;

internal class Counting_Bits_Test {
    
    [TestCase(2, new[]{0,1,1})]
    [TestCase(5, new[]{0,1,1,2,1,2})]
    public void Test(int n, int[] expected) 
    {
        var hammingWeights = Counting_Bits.CountBits(n);
        Assert.That(hammingWeights, Is.EqualTo(expected));
    }
}