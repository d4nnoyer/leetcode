using LeetCodeSolutions.Solutions.HashTable.Medium;

namespace LeetCodeSolutions.Tests.HashTable.Medium;

public class Insert_Delete_GetRandom_O_1__Test {

    [TestCase]
    public void ShouldGetRandom()
    {
        var randomizedSet = new Insert_Delete_GetRandom_O_1_.RandomizedSet();
        randomizedSet.Insert(1);
        var insert = randomizedSet.Insert(2);
        var insertAgain = randomizedSet.Insert(2);
        var remove  = randomizedSet.Remove(2);
        var removeAgain  = randomizedSet.Remove(2);

        for (int i = 10; i < 100; i++) 
            randomizedSet.Insert(i);

        for (int i = 10; i < 100; i++)
        {
            var rnd = randomizedSet.GetRandom();
        }
        
        Assert.That(insert, Is.True);
        Assert.That(insertAgain, Is.False);
        Assert.That(remove, Is.True);
        Assert.That(removeAgain, Is.False);
    }
}