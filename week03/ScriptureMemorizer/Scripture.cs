using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
          Word newWord = new Word(word);
          _words.Add(newWord);  
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        int hideCount = 0;

        while (hideCount < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hideCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}