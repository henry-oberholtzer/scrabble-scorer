namespace ScrabbleScorer.Models;

[TestClass]
public class WordTest
{
    [TestMethod]
    public void WordConstruct_CreatesInstaceOfWord_Word()
    {
        Word newWord = new Word("muenster");
        Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstruct_GetWord_String()
    {
        string gorg = "gorgonzola";
        Word newWord = new(gorg);
        Assert.AreEqual(gorg, newWord.Played);
    }

    [TestMethod]
    public void WordConstruct_SetWord_void()
    {
        string brie = "brie";
        Word newWord = new(brie);
        string camembert = "camembert";
        newWord.Played = camembert;
        Assert.AreEqual(camembert, newWord.Played);
    }
}
