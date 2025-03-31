using LeetCodeSolutions.Solutions.String.Hard;

namespace LeetCodeSolutions.Tests.String.Hard;

internal class Text_Justification_Test {
    
    [TestCase(new[]{"This", "is", "an", "example", "of", "text", "justification."}, 16, new[]{
        "This    is    an",
        "example  of text",
        "justification.  "})]
    [TestCase(new[]{"What","must","be","acknowledgment","shall","be"}, 16, new[]{
        "What   must   be",
        "acknowledgment  ",
        "shall be        "})]
    [TestCase(new[]{"Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"}, 20, new[]{
        "Science  is  what we",
        "understand      well",
        "enough to explain to",
        "a  computer.  Art is",
        "everything  else  we",
        "do                  "})]
    [TestCase(new[]{"My","momma","always","said,","\"Life","was","like","a","box","of","chocolates.","You","never","know","what","you're","gonna","get."}, 20, new[]{
        "My    momma   always",
        "said, \"Life was like",
        "a box of chocolates.",
        "You  never know what",
        "you're gonna get.   "})]
    public void Test(string[] words, int maxWidth, IList<string> expected) 
    {
        var justifiedWords = Text_Justification.FullJustify(words, maxWidth);
        Assert.That(justifiedWords, Is.EqualTo(expected));
    }
}