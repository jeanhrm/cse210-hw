using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText} - {wordsText}";
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        int wordsToHide = Math.Min(numberToHide, visibleIndexes.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            if (visibleIndexes.Count == 0)
            {
                break;
            }

            int randomPosition = _random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomPosition];

            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randomPosition);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
