using System;

class Scripture
{
    private string scriptureText;

    private Reference sccriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
        sccriptureReference = _scriptureReference;
        scriptureText = _scriptureText;
    }

    public string tostring()
    {
        return string.format("{0}", scriptureText);
    }
}