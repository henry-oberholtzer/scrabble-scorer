namespace ScrabbleScorer.Models;

[TestClass]
public class WordTest
{
    [TestMethod]
    public void WordConstruct_CreatesInstaceOfWord_Word()
    {
        Word newWord = new Word();
        Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstruct_GetWord_String() 
    { 
        string gorg = "gorgonzola"
        Word newWord = new(gorg);
        Assert.AreEqual(gorg, newWord.Played)

    }
}
