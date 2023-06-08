namespace Playground.Solutions.Array.Easy;

public class Pascal_s_Triangle_II {
    
    public static IList<int> GetRow(int rowIndex)
    {
        var row = new List<int>(rowIndex+1){1};

        for (int i = 0; i < rowIndex; i++)
        {
            long newValue = (long)row[i] * (rowIndex - i) / (i + 1);
            row.Add((int)newValue);
        }
        
        return row;
    }
    
}