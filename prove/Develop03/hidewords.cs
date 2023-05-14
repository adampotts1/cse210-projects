public class HideWords
{
    private static List<string> scriptureTextList = new List<string>();
    
    private List<int> StoredIndex = new List<int>();

    Random random = new Random();

    public HideWords()
    {
        scriptureTextList.Add("No Scripture Given");
    }
    public HideWords(List<string> input)
    {
        scriptureTextList = input;
    }

    public void replaceWords()
    {
        int index1 = random.Next(1, StoredIndex.Count);
        int index2 = random.Next(1, StoredIndex.Count);
        int index = StoredIndex[index1];
        int _index = StoredIndex[index2];

        if ((StoredIndex.Contains(index)))
        {
            scriptureTextList[index] = "____";
            if (StoredIndex.Count != 2)
            {
                scriptureTextList[_index]= "____";
            }
            ScriptureReferrence SR = new ScriptureReferrence();
            foreach (string word in scriptureTextList)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();

            if (StoredIndex.Count != 1)
            {
                StoredIndex.Remove(index);
                StoredIndex.Remove(_index);
            }
        } 
    }

    public void displayWithHidden()
    {
        foreach (string word in scriptureTextList)
        {
            Console.Write($"{word} ");
        }
    }

    public void createStoredIndexList()
    {
        int listLength = ((scriptureTextList.Count));
        IEnumerable<int> storedIndex = Enumerable.Range(0, listLength);
        foreach (int number in storedIndex)
        {
            StoredIndex.Add(number);
        }
    }

    public int stopLoop()
    {
        int indexCount = StoredIndex.Count;
        return indexCount;
    }
}