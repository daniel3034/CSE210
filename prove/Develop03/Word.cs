using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string _Text {get; private set;}
    public bool isHidden {get; private set;}

    public Word(string text)
    {
        _Text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public override string ToString()
    {
        return isHidden ? "_______" : _Text;
    }
}