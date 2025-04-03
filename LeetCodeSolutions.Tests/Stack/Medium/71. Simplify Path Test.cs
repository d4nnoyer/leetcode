using LeetCodeSolutions.Solutions.Stack.Medium;

namespace LeetCodeSolutions.Tests.Stack.Medium;

public class Simplify_Path_Test {
    
    [TestCase("/home/", "/home")]
    [TestCase("/home//foo/", "/home/foo")]
    [TestCase("/home/user/Documents/../Pictures", "/home/user/Pictures")]
    [TestCase("/../", "/")]
    [TestCase("/.../a/../b/c/../d/./", "/.../b/d")]
    [TestCase("/a/./b/../../c/", "/c")]
    public void Test(string path, string expectedResult) 
    {
        var amount = Simplify_Path.SimplifyPath(path);
        Assert.That(amount, Is.EqualTo(expectedResult));
    }
}