using LeetCodeSolutions.Solutions.Stack.Medium;

namespace LeetCodeSolutions.Tests.Stack.Medium;

public class Asteroid_Collision_Test {
    
    [TestCase(new[]{5,10,-5}, new[]{5,10})]
    [TestCase(new[]{8,-8}, new int[]{})]
    [TestCase(new[]{10,2,-5}, new[]{10})]
    [TestCase(new[]{-1,-2,2,1}, new[]{-1,-2,2,1})]
    [TestCase(new[]{-2,-2,1,-2}, new int[]{-2,-2,-2})]
    [TestCase(new[]{-2,-2,1,-1}, new int[]{-2,-2})]
    public void Test(int[] asteroids, int[] expectedResult) 
    {
        var remainingAsteroids = Asteroid_Collision.AsteroidCollision(asteroids);
        Assert.That(remainingAsteroids, Is.EqualTo(expectedResult));
    }
}