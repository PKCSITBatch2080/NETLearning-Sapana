// generic method ==> type as a argument
using System;

class Generic
{
    public T Display<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
        return value;
    }
}