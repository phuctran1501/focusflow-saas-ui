namespace FocusFlow.ViewModels;

public class InsightCard
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IconType { get; set; } = "lightning"; // "lightning", "trending", "moon"
    public string IconBg { get; set; } = "#EEEDFF";
    public string IconColor { get; set; } = "#635BFF";
}

public class InsightsViewModel
{
    public double ProductivityScore { get; set; } = 84.2;
    public string ScoreTrend { get; set; } = "↑ 12%";
    public int StreakDays { get; set; } = 12;
    public int TopPercentile { get; set; } = 5;
    public int CompletedTasksCount { get; set; } = 142;
    public int PendingTasksCount { get; set; } = 25;
    public int CompletionRate { get; set; } = 85;
    public double WeeklyFocusHours { get; set; } = 28.4;
    public List<InsightCard> Insights { get; set; } = new();
}
