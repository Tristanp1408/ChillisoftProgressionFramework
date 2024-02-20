namespace Generics;

public class Box<T>
{
    private readonly T _data;

    public Box(T data)
    {
        _data = data;
    }

    public T GetData()
    {
        return _data;
    }
}