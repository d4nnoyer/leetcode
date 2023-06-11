namespace LeetCodeSolutions.Tests.Array.Easy;

public class Pascal_s_Triangle_II_Test {
    
    [TestCaseSource(nameof(_triangles))]
    public void Test(int numRows, IList<int> result) 
    {
        var triangles = Pascal_s_Triangle_II.GetRow(numRows);
                
        Assert.That(triangles, Is.EqualTo(result));
    }
    
    private static object[] _triangles = {
        new object[] {0, new List<int> {1}},
        new object[] {1, new List<int> {1,1}},
        new object[] {2, new List<int> {1,2,1}},
        new object[] {3, new List<int> {1,3,3,1}},
        new object[] {30, new List<int> {1,30,435,4060,27405,142506,593775,2035800,5852925,14307150,30045015,54627300,86493225
            ,119759850,145422675,155117520,145422675,119759850,86493225,54627300,30045015,14307150,5852925,2035800,593775,142506,27405,4060,435,30,1}}
    };
}