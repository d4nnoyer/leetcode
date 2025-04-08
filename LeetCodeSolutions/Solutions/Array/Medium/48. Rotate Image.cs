namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Rotate_Image {
    public static void Rotate(int[][] matrix)
    {
        matrix.AsSpan().Reverse();
        for (int i = 0; i < matrix.Length; i++)
            for (int j = i + 1; j < matrix.Length; j++) 
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
    }
}