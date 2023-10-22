using System;
using System.Collections.Generic;
using System.Linq;

//scriptures and words class
public class Scripture
{
   // property
    public Reference Reference { get; }
    private List<Word> WordList;
    //scripture object
    public Scripture(Reference reference, List<string> text)
    {
        Reference = reference;
        WordList = text.Select(word => new Word(word)).ToList();
    }
    //want to hide some words randomly
    public void HideRandomWords(int count)
    {
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(WordList.Count);
            WordList[randomIndex].Hide();
        }
    }
//are all words hidden? boolean=true or false
    public bool AreAllWordsHidden()
    {
        return WordList.All(word => word.IsHidden);
    }
//scripture text with hidden words method
    public string GetRenderedText()
    {
        //jioning words
        return string.Join(" ", WordList.Select(word => word.GetRenderedText()));
    }
}
