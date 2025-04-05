namespace LeetCodeSolutions.Solutions.Stack.Medium;

public class Asteroid_Collision {
    
    public static int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>(asteroids.Length);
        foreach (var asteroid in asteroids)
        {
            if (asteroid > 0)
            {
                stack.Push(asteroid);
                continue;
            }
            
            while (stack.TryPeek(out var previous) && previous > 0 && previous < -asteroid) 
                stack.Pop();
            
            if (stack.Count == 0 || stack.Peek() < 0) 
                stack.Push(asteroid);
            
            if (stack.Peek() == -asteroid) 
                stack.Pop();
        }

        var result = new int[stack.Count];
        for (var index = stack.Count - 1; index >= 0; index--)
            result[index] = stack.Pop();
        
        return result;
    }
}