class Reference
{
    private string book;
    private string chapter;
    private string verse;

    public Reference(string _book, string _chapter, string _verse)

    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
    }
    public string tostring()
    {
        return string.format("{0} {1} {2}");
    }

}