namespace ScrabbleScorer.Models;

[TestClass]
public class WordTest : IDisposable
{
    public void Dispose()
    {
        Word.ClearAll();
    }

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

    [TestMethod]
    public void WordConstruct_ClearAll_Void()
    {
        List<Word> expected = [];
        Word.ClearAll();
        CollectionAssert.AreEqual(expected, Word.GetAll());
    }

    [TestMethod]
    public void WordConstruct_GetAll_Void()
    {
        Word cheddar = new Word("cheddar");
        Word swiss = new Word("swiss");
        Word parmesan = new Word("parmigiano reggiano");
        List<Word> expected = new List<Word> { cheddar, swiss, parmesan };
        CollectionAssert.AreEqual(expected, Word.GetAll());
    }
}
