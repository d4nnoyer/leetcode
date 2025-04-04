using LeetCodeSolutions.Solutions.HashTable.Medium;

namespace LeetCodeSolutions.Tests.HashTable.Medium;

public class Valid_Sudoku_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(char[][] board, bool expectedResult)
    {
        var isValid = Valid_Sudoku.IsValidSudoku(board);
        
        Assert.That(isValid, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {new char[][]{
             ['5','3','.','.','7','.','.','.','.']
            ,['6','.','.','1','9','5','.','.','.']
            ,['.','9','8','.','.','.','.','6','.']
            ,['8','.','.','.','6','.','.','.','3']
            ,['4','.','.','8','.','3','.','.','1']
            ,['7','.','.','.','2','.','.','.','6']
            ,['.','6','.','.','.','.','2','8','.']
            ,['.','.','.','4','1','9','.','.','5']
            ,['.','.','.','.','8','.','.','7','9']
        }, true},
        new object[] {new char[][]{
             ['8','3','.','.','7','.','.','.','.']
            ,['6','.','.','1','9','5','.','.','.']
            ,['.','9','8','.','.','.','.','6','.']
            ,['8','.','.','.','6','.','.','.','3']
            ,['4','.','.','8','.','3','.','.','1']
            ,['7','.','.','.','2','.','.','.','6']
            ,['.','6','.','.','.','.','2','8','.']
            ,['.','.','.','4','1','9','.','.','5']
            ,['.','.','.','.','8','.','.','7','9']
        }, false},
    ];
}