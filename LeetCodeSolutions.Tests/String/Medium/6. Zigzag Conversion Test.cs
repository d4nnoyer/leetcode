using LeetCodeSolutions.Solutions.String.Medium;

namespace LeetCodeSolutions.Tests.String.Medium;

public class Zigzag_Conversion_Test {
   
    [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [TestCase("A", 1, "A")]
    public void Test(string text, int numRows, string expectedString) 
    {
        var zigzagString = Zigzag_Conversion.Convert(text, numRows);
        Assert.That(zigzagString, Is.EqualTo(expectedString));
    }
}