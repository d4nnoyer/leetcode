namespace LeetCodeSolutions.Tests.Array.Easy;

public class Pascal_s_Triangle_Test {
    
    
    [TestCaseSource(nameof(_triangles))]
    public void Test(int numRows, IList<IList<int>> result) 
    {
        var triangles = Pascal_s_Triangle.Generate(numRows);
                
        Assert.That(triangles, Is.EqualTo(result));
    }


    private static object[] _triangles = {
        new object[] {1, new List<IList<int>> { new List<int> {1} }},
        new object[] {2, new List<IList<int>> { new List<int> {1}, new List<int> {1,1} }},
        new object[] {3, new List<IList<int>> { new List<int> {1}, new List<int> {1,1}, new List<int> {1,2,1} }},
        new object[] {4, new List<IList<int>> { new List<int> {1}, new List<int> {1,1}, new List<int> {1,2,1}, new List<int> {1,3,3,1} }}
    };

}