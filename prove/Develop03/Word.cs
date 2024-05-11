using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string _Text {get; private set;}
    public bool _isHidden {get; private set;}

    public Word(string text)
    {
        _Text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public override string ToString()
    {
        return _isHidden ? "_______" : _Text;
    }
}