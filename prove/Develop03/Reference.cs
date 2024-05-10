using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string _Verse {get; private set;}

    public Reference(string verse)
    {
        _Verse = verse;
    }

    public override string ToString()
    {
        return _Verse;
    }
}
