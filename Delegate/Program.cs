CustomList<int> CustomListInt = new CustomList<int>();
CustomListInt.Add(125);
CustomListInt.Add(347);
Console.WriteLine(CustomListInt.Count());
Console.WriteLine(CustomListInt.Find(x=>x%2==0));

CustomList<string> CustomListStr = new CustomList<string>();
CustomListStr.Add("Hello, ");
CustomListStr.Add("World!");
Console.WriteLine(CustomListStr.Count());
Console.WriteLine(CustomListStr.Find(data=>data.Length<=6));

class CustomList<T>
{
    private T[] _items = new T[0];
    public void Add(T data)
    {
        Array.Resize(ref _items, _items.Length + 1);
        _items[_items.Length - 1] = data;
    }

    public int Count()
    { return _items.Length; }

    public T Find(Predicate<T> pr)
    {
        foreach (T item in _items)
        {
            if (pr(item)) { return item; }
        }

        return default(T);
    }
}