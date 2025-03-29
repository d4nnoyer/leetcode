using LeetCodeSolutions.Solutions.String.Medium;

namespace LeetCodeSolutions.Tests.String.Medium;

public class Integer_to_Roman_Test
{
    [TestCase(3749, "MMMDCCXLIX")]
    [TestCase(58, "LVIII")]
    [TestCase(1994, "MCMXCIV")]
    [TestCase(1594, "MDXCIV")]
    [TestCase(1494, "MCDXCIV")]
    [TestCase(1394, "MCCCXCIV")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(14, "XIV")]
    [TestCase(19, "XIX")]
    [TestCase(17, "XVII")]
    public void Test(int number, string expectedString) 
    {
        var romanNumeral = Integer_to_Roman.IntToRoman(number);
        Assert.That(romanNumeral, Is.EqualTo(expectedString));
    }
}