public class Scripture
    {
    public Reference Reference;
    private List<Word> words;

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            words = new List<Word>();
            string[] Awords = text.Split(' ');
            foreach (string w in Awords)
            {
                words.Add(new Word(w));
            }
        }
        
        public void HideRandomWords(int count)
        {
            List<int> notHiddenIndices = new List<int>();
            for (int i = 0; i < words.Count; i++)
            {
                if (!words[i].IsHidden)
                    notHiddenIndices.Add(i);
            }

            int wordsToHide = Math.Min(count, notHiddenIndices.Count);
            Random rnd = new Random();

            for (int i = 0; i < wordsToHide; i++)
            {
                
                int randIndex = rnd.Next(notHiddenIndices.Count);
                int wordFromIndex = notHiddenIndices[randIndex];
                words[wordFromIndex].Hide();
                
                notHiddenIndices.RemoveAt(randIndex);
            }
        }


    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{Reference.GetDisplayText()}\n{scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            return false;
        }
        return true;
    }
}
