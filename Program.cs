using System.Runtime.InteropServices;

public class ThisTest
{
    public static void Main(string[] args)
    {
        SimpleTime time = new SimpleTime(15, 30, 19);
        Console.WriteLine(time.BuildString());
    }
}

public class SimpleTime
{
    private int hour;
    private int minute;
    private int second;

    public SimpleTime(int hour, int minute, int second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public string BuildString()
    {
        return string.Format("{0,24}: {1}\n{2,24}: {3}",
           "this.ToUniversalString()", this.ToUniversalString(),
            "ToUniversalString()", ToUniversalString());
    }

    private string ToUniversalString()
    {
        return string.Format($"{this.hour:D2}:{this.minute:D2}:{this.second}");
    }
}