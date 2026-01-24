public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] extractedWord = text.Split(" ");
        foreach (string word in extractedWord)
        {
            Word singleWord = new Word(word);
            _words.Add(singleWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i< numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            while (_words[index].IsHidden())
            {
                index = rand.Next(_words.Count);
            } 
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            string wordText = word.GetDisplayText();
            displayText = ($"{displayText} {wordText}");
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            return false;
        }
        return true;
    }
}