namespace LeetCodeSolutions.Solutions.DynamicProgramming.Medium;

public static class Solving_Questions_With_Brainpower {
    
    public static long MostPoints(int[][] questions)
    {
        var n = questions.Length;
        Span<long> maxPoints = stackalloc long[n];
        maxPoints[^1] = questions[^1][0];

        for (int i = n - 2; i >= 0; i--)
        {
            var pts = questions[i][0];
            var bp = questions[i][1];
            var nextIndex = i + bp + 1;
            maxPoints[i] = pts + (nextIndex >= n 
                ? 0 
                : maxPoints[nextIndex]);

            maxPoints[i] = Math.Max(maxPoints[i], maxPoints[i + 1]);
        }
            
        return maxPoints[0];
    }
}