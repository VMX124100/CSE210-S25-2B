public class Word
{
    public string text;
    public bool IsHidden = false;

    public Word(string original)
    {
        text = original;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string GetDisplayText()
    {
        if (IsHidden)
        {
            string hidden = "";
            for (int i = 0; i < text.Length; i++)
            {
                hidden += "_";
            }
            return hidden;
        }
        else
        {
            return text;
        }

    }
}
