namespace Playground.Solutions.Array.Easy;

public class Pascal_s_Triangle {
    
    public static IList<IList<int>> Generate(int numRows)
    {
        var triangle = new List<IList<int>>(numRows) { new List<int> { 1 } };
        
        for (int i = 1; i < numRows; i++)
        {
            var newRow = new List<int>(i+1);
            var prevRow = triangle.Last();

            newRow.Add(prevRow.First());

            for (int j = 1; j < i; j++)
                newRow.Add(prevRow[j-1] + prevRow[j]);
            
            newRow.Add(prevRow.Last());
            
            triangle.Add(newRow);
        }

        return triangle;
    }
    
}