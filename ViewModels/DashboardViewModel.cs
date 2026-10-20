using FocusFlow.Models;

namespace FocusFlow.ViewModels;

public class DailyFocusBar
{
    public string DayShort { get; set; } = string.Empty; // S, M, T, W, T, F, S
    public string DayName { get; set; } = string.Empty;
    public double Hours { get; set; }
    public int HeightPercent { get; set; }
    public bool IsPeak { get; set; }
}

public class DashboardViewModel
{
    public string UserName { get; set; } = "Alex";
    public int ActiveProjects { get; set; } = 12;
    public int CompletedTasks { get; set; } = 48;
    public double WeeklyFocusHours { get; set; } = 18.5;
    public int StreakDays { get; set; } = 12;
    public string GrowthPercentage { get; set; } = "+12% vs last week";

    public List<DailyFocusBar> WeeklyTrend { get; set; } = new();
    public List<TaskItem> TodayPlan { get; set; } = new();
    public List<FocusSession> RecentSessions { get; set; } = new();
}
