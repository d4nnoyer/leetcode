namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Spiral_Matrix_II {
    
    public static int[][] GenerateMatrix(int n)
    {
        var matrix = new int[n][];
        for (int i = 0; i < n; i++)
            matrix[i] = new int[n];

        int startRow = 0, endRow = matrix.Length - 1;
        int startCol = 0, endCol = matrix[0].Length - 1;
        
        int dir = 0;
        int value = 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            switch (dir % 4)
            {
                case 0://right
                    for (int col = startCol; col <= endCol; col++)
                        matrix[startRow][col] = value++;
                    startRow++;
                    break;
                case 1://down
                    for (int row = startRow; row <= endRow; row++)
                        matrix[row][endCol] = value++;
                    endCol--;
                    break;
                case 2://left
                    for (int col = endCol; col >= startCol; col--)
                        matrix[endRow][col] = value++;
                    endRow--;
                    break;
                case 3://up
                    for (int row = endRow; row >= startRow; row--)
                        matrix[row][startCol] = value++;
                    startCol++;
                    break;
            }
        
            dir++;
        }

        return matrix;
    }
    
}