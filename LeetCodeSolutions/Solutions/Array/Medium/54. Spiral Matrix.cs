namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Spiral_Matrix {
    
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        int startRow = 0, endRow = matrix.Length - 1;
        int startCol = 0, endCol = matrix[0].Length - 1;
        
        int dir = 0;

        var spiralOrder = new List<int>(matrix.Length * matrix[0].Length);

        while (startRow <= endRow && startCol <= endCol)
        {
            switch (dir % 4)
            {
                case 0://right
                    for (int col = startCol; col <= endCol; col++)
                        spiralOrder.Add(matrix[startRow][col]);
                    startRow++;
                    break;
                case 1://down
                    for (int row = startRow; row <= endRow; row++)
                        spiralOrder.Add(matrix[row][endCol]);
                    endCol--;
                    break;
                case 2://left
                    for (int col = endCol; col >= startCol; col--)
                        spiralOrder.Add(matrix[endRow][col]);
                    endRow--;
                    break;
                case 3://up
                    for (int row = endRow; row >= startRow; row--)
                        spiralOrder.Add(matrix[row][startCol]);
                    startCol++;
                    break;
            }
        
            dir++;
        }

        return spiralOrder;
    }

}