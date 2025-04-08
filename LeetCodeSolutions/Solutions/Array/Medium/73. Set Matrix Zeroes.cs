namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Set_Matrix_Zeroes {
    
    public static void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        Span<bool> zeroRows = stackalloc bool[m];
        Span<bool> zeroCols = stackalloc bool[n];

        for (var row = 0; row < m; row++)
        for (var col = 0; col < n; col++)
            if (matrix[row][col] == 0)
            {
                zeroRows[row] = true;
                zeroCols[col] = true;
            }

        for (var row = 0; row < m; row++)
            if (zeroRows[row])
                for (var col = 0; col < n; col++)
                    matrix[row][col] = 0;
        
        for (var col = 0; col < n; col++)
            if (zeroCols[col])
                for (var row = 0; row < m; row++)
                    matrix[row][col] = 0;
    }
}