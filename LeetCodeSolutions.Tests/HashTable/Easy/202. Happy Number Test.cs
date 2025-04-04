namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Happy_Number_Test {
    
    [TestCase(19, true)]
    [TestCase(2, false)]
    public void Test(int number, bool expectedResult)
    {
        var isHappy = Happy_Number.IsHappy(number);
        
        Assert.That(isHappy, Is.EqualTo(expectedResult));
    }
}