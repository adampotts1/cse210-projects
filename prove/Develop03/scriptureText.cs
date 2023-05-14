public class ScriptureText
{
    private string _scriptureText = "";
    private List<string> scriptureListForm = new List<string>();
    
    public ScriptureText()
    {
    }

    public void _scriptureTextToList()
    {
        string [] words = _scriptureText.Split(' ');

        scriptureListForm.Add(" ");
        foreach (string word in words)
        {
            scriptureListForm.Add(word);
        }
    }

    public void displayScriptureText()
    {
        foreach (string word in scriptureListForm)
        {
            Console.Write($"{word} ");
        }
    }

    public string setScriptureText(string input)
    {
        _scriptureText = input;
        _scriptureTextToList();
        return _scriptureText;
    }

    public List<string> getScriptureList()
    {
        return scriptureListForm;
    }
}