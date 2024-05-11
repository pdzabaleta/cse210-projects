using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
{
    // Si la palabra está oculta, devuelve una serie de guiones bajos
    if (_isHidden)
    {
        return "___";
    }
    else
    {
        // Si la palabra no está oculta, devuelve el texto de la palabra
        return _text;
    }
}

    

}