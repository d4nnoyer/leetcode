using LeetCodeSolutions.Solutions.Queue.Easy;

namespace LeetCodeSolutions.Tests.Queue.Easy;

public class Number_of_Recent_Calls_Test {
    
    [TestCase]
    public void Test()
    {
        var counter = new RecentCounter();
        int callsCount;
        
        callsCount = counter.Ping(1);
        Assert.That(callsCount, Is.EqualTo(1));
        
        callsCount = counter.Ping(100);
        Assert.That(callsCount, Is.EqualTo(2));
        
        callsCount = counter.Ping(3001);
        Assert.That(callsCount, Is.EqualTo(3));
        
        callsCount = counter.Ping(3002);
        Assert.That(callsCount, Is.EqualTo(3));
    }
}