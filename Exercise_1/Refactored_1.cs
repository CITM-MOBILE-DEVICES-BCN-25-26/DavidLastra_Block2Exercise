using System;

public class MatchSummary
{
    public int Score;
    public int EnemiesKilled;
    public int TimePlayedInSeconds;
}

public class MatchSummaryCalculator
{
    public float CalculatePerformance(MatchSummary summary)
    {
        return summary.Score / (float)(summary.TimePlayedInSeconds + 1);
    }
}

public class MatchSummaryFormatter
{
    public string FormatSummary(MatchSummary summary, float performance)
    {
        return $"Score: {summary.Score} | Kills: {summary.EnemiesKilled} | Performance: {performance:F2}";
    }
}

public interface IMatchSummaryExporter
{
    void Export(MatchSummary summary);
}

public class JsonMatchSummaryExporter : IMatchSummaryExporter
{
    public void Export(MatchSummary summary)
    {
        Console.WriteLine("Exporting match summary to JSON...");
    }
}

public class XmlMatchSummaryExporter : IMatchSummaryExporter
{
    public void Export(MatchSummary summary)
    {
        Console.WriteLine("Exporting match summary to XML...");
    }
}
