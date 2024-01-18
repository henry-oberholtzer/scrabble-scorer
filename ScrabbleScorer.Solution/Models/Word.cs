namespace ScrabbleScorer.Models
{
    public class Word
    {
        public string Played { get; set; }

        private static List<Word> _instances = [];

        public Word(string played)
        {
            Played = played;
            _instances.Add(this);
        }

        public static List<Word> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
