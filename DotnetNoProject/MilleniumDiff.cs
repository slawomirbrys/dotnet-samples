#:package Humanizer@2.14.1

using Humanizer;

public class MilleniumDiff
{
    private readonly DateTime _startTime = new DateTime(2000, 1, 1);

    public override string ToString()
    {
        var now = DateTime.Now;
        return $"Since Millenium it passed {(now - _startTime).Humanize()} already.";
    }
}