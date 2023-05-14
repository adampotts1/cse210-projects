public class ScriptureReferrence
{
    private string _scripture = "";

    private string _scriptureReferrenceText = "";

    public ScriptureReferrence()
    {
        _scripture = "1 Nephi 1:16";
        _scriptureReferrenceText = "For the time soon cometh that the fulness of the wrath of God shall be poured out upon all the children of men; for he will not suffer that the wicked shall destroy the righteous.";
    }

    public ScriptureReferrence(string referrence)
    {
        _scripture = referrence;
    }

    public string getSR(){
        return _scripture;
    }

    public string getSRText(){
        return _scriptureReferrenceText;
    }

}