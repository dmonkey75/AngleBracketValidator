namespace JobNimbus.Exam;

public class AngleBracketStore
{
    private readonly char openBracket = '<';
    private readonly List<char> _items = new();
    public IReadOnlyCollection<char> Items => _items;

    public void Add()
    {
        //add new open bracket in the list.
        _items.Add(openBracket);
    }

    public void Remove()
    {
        //Remote the last element in the list.
        _items.RemoveAt(_items.Count - 1);
    }
}
