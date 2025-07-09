public class Reference
{
    public string Book;
    public int Chapter;
    public int VerseStart;
    public int VerseEnd;

        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            VerseStart = verse;
        }

        public Reference(string book, int chapter, int verseStart, int verseEnd)
        {
            Book = book;
            Chapter = chapter;
            VerseStart = verseStart;
            VerseEnd = verseEnd;
        }

        public string GetDisplayText()
        {
            if (VerseEnd > 0 && VerseEnd != VerseStart)
            {
                return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
            }
            else
            {
                return $"{Book} {Chapter}:{VerseStart}";
            }
        }
    }
