namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Game_of_Life
{
    private const int dead = 0;
    private const int live = 1;
    
    private const int deadNowDeadNext = 0;
    private const int liveNowDeadNext = 1;
    private const int deadNowLiveNext = 2;
    private const int liveNowLiveNext = 3;
    
    public static void GameOfLife(int[][] board) {
        var m = board.Length;
        var n = board[0].Length;

        for (int row = 0; row < m; row++)
        for (int col = 0; col < n; col++)
            board[row][col] = GetState(board, row, col);
        
        for (int row = 0; row < m; row++)
        for (int col = 0; col < n; col++)
            board[row][col] /= 2;
    }

    private static int GetState(int[][] matrix, int row, int col)
    {
        var count = 0;
        for (int r = row - 1; r <= row + 1; r++)
        for (int c = col - 1; c <= col + 1; c++)
        {
            if(r < 0 || c < 0 || r >= matrix.Length || c >= matrix[r].Length || r == row && c == col)
                continue;
            if (matrix[r][c] % 2 == live)
                count++;
        }

        return matrix[row][col] switch
        {
            dead when count == 3 => deadNowLiveNext,
            live when count < 2 => liveNowDeadNext,
            live when count > 3 => liveNowDeadNext,
            live when count is 2 or 3 => liveNowLiveNext,
            _ => deadNowDeadNext
        };
    }
}