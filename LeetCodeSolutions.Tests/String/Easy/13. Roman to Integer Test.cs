namespace LeetCodeSolutions.Tests.String.Easy;

internal class Roman_to_Integer_Test {
    
    [TestCase("III", 3)]
    [TestCase("IV", 4)]
    [TestCase("XIV", 14)]
    [TestCase("XIX", 19)]
    [TestCase("XVII", 17)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXCIV", 1994)]
    public void Test(string romanNumeral, int expectedNumber) 
    {
        var number = Roman_to_Integer.RomanToInt(romanNumeral);
        Assert.That(number, Is.EqualTo(expectedNumber));
    }
}