using System;

class ScriptureMemorizer
{
    private Scripture scripture;

    private List<string> scriptureTextList;

    public ScriptureMemorizer (Scripture _scripture)
    {
        Scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextList = scripture.tostring().Split(' ').ToList();
    }

    public void removeWordsFromList()
    {
        int numWordsToRemove = new Random().Next(3);
        int wordRemoved = 0;

        do{
            int rndIndex = new Random().Next(0, scriptureTextList.Count());

            if (scriptureTextList[rndIndex].Contains('_' ) == false)
            {
            scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Count);
            wordsRemove++;
            }
        
        }while (wordRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return tostring.Join(' ', scriptureTextList);
    }
    
        
    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scriptureTextList)
        {
            if (word.Contains('_')== false)
            {
                retvalue = true;
                break;
            }
        }
        return retvalue;
    }
}