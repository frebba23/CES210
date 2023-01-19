using System;
using System.IO;
using System.Text;

public class Response
{
    PromptGenerator proGen = new PromptGenerator();
    DateTime _date = DateTime.Now;
    public string _promptResponse;

    public string ResponseDisplay(){
        _promptResponse = (sting.Format("{0} Prompt: {1}", _date, proGen.displayPrompt()));
        return _promptResponse;
    }
}