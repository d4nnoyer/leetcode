namespace LeetCodeSolutions.Solutions.HashTable.Medium;

public static class Equal_Row_and_Column_Pairs {
    
    public static int EqualPairs(int[][] grid)
    {
        var length = grid.Length;
        Span<int> rowHashes = stackalloc int[length];
        Span<int> colHashes = stackalloc int[length];
        
        for (int i = 0; i < length; i++)
        {
            var rowHash = 0;
            var colHash = 0;
            for (int j = 0; j < length; j++)
            {
                rowHash = rowHash * 17 + grid[i][j];
                colHash = colHash * 17 + grid[j][i];
            }

            rowHashes[i] = rowHash;
            colHashes[i] = colHash;
        }

        var pairs = 0;
        for (int i = 0; i < length; i++)
        {
            var rowHash = rowHashes[i];
            for (int j = 0; j < length; j++)
            {
                var colHash = colHashes[j];
                if (rowHash == colHash)
                    pairs++;
            }
        }
        
        return pairs;
    }
}