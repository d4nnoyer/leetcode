namespace LeetCodeSolutions.Solutions.HashTable.Medium;

public static class Valid_Sudoku {
    
    private const char Empty = '.';

    public static bool IsValidSudoku(char[][] board)
    {
        const int length = 9;
        var numsSet = new HashSet<char>(length);
        
        for (int i = 0; i < length; i++)
        {   // Rows
            numsSet.Clear();
            for (int j = 0; j < length; j++)
                if (IsInvalid(numsSet, board[i][j]))
                    return false;
        }
        
        for (int i = 0; i < length; i++)
        {   // Columns
            numsSet.Clear();
            for (int j = 0; j < length; j++)
                if (IsInvalid(numsSet, board[j][i]))
                    return false;
        }
        
        for (int boxIndex = 0; boxIndex < length; boxIndex++)
        {   // Boxes
            numsSet.Clear();
            var rowStart = (boxIndex / 3) * 3;
            var colStart = (boxIndex % 3) * 3;
            for (int rowIndex = rowStart; rowIndex < rowStart + 3; rowIndex++)
                for (int colIndex = colStart; colIndex < colStart + 3; colIndex++)
                    if (IsInvalid(numsSet, board[rowIndex][colIndex]))
                        return false;
        }
        
        return true;
    }

    private static bool IsInvalid(HashSet<char> chars, char c) => c != Empty && !chars.Add(c);
}