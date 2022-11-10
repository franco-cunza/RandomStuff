public class Destination
{
    public string FooBar { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"FooBar = {FooBar}";
    }
}