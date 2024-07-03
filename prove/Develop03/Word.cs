
public class Word
{
    private string _text;
    public  Word(string text)
    {
        _text = text ;
        
    }


    public void  Hide()
    {
      _text = "__";  
    }
    public void Show()
    {
      string text = _text;
    }
     public string GetDisplayText()
     {
         string text = _text;
         return text;
     }
}
