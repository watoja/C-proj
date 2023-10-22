//class for words
public class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }
//word object
    public Word(string text)
    {
        //set word to hidden mode=false=visible by core
        Text = text;
        IsHidden = false;
    }
     //hiding word method
    public void Hide()
    {
       // successfully hide word
        IsHidden = true;
    }
     //disclose word
    public void Show()
    {
        IsHidden = false;
    }
    //get rendered text()
    public string GetRenderedText()
    {
        return IsHidden ? "_______" : Text;
    }
}
