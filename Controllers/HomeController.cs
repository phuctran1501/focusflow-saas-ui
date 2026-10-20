using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FocusFlow.Models;
using FocusFlow.ViewModels;

namespace FocusFlow.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new DashboardViewModel
        {
            UserName = "Alex",
            ActiveProjects = 12,
            CompletedTasks = 48,
            WeeklyFocusHours = 18.0,
            StreakDays = 12,
            GrowthPercentage = "+12% vs last week",
            WeeklyTrend = new List<DailyFocusBar>
            {
                new() { DayShort = "S", DayName = "Sunday", Hours = 1.5, HeightPercent = 25, IsPeak = false },
                new() { DayShort = "M", DayName = "Monday", Hours = 4.0, HeightPercent = 65, IsPeak = false },
                new() { DayShort = "T", DayName = "Tuesday", Hours = 3.0, HeightPercent = 50, IsPeak = false },
                new() { DayShort = "W", DayName = "Wednesday", Hours = 5.8, HeightPercent = 95, IsPeak = true },
                new() { DayShort = "T", DayName = "Thursday", Hours = 4.2, HeightPercent = 70, IsPeak = false },
                new() { DayShort = "F", DayName = "Friday", Hours = 4.5, HeightPercent = 75, IsPeak = false },
                new() { DayShort = "S", DayName = "Saturday", Hours = 1.0, HeightPercent = 18, IsPeak = false }
            },
            TodayPlan = new List<TaskItem>
            {
                new() { Id = 1, Title = "Review Q3 design tokens & styling system", Category = "Product Design", Priority = "High", Status = "Doing", DueDate = "Today, 3:00 PM", IsCompleted = false },
                new() { Id = 2, Title = "Email marketing team weekly campaign copy", Category = "Marketing", Priority = "Medium", Status = "Todo", DueDate = "Today, 5:30 PM", IsCompleted = false },
                new() { Id = 3, Title = "Finalize API contract for focus sessions", Category = "Engineering", Priority = "High", Status = "Completed", DueDate = "Completed 11:30 AM", IsCompleted = true },
                new() { Id = 4, Title = "Update landing page hero copy & CTA", Category = "Growth", Priority = "Low", Status = "Todo", DueDate = "Tomorrow", IsCompleted = false }
            },
            RecentSessions = new List<FocusSession>
            {
                new() { Id = 101, Title = "Deep Work: SaaS Dashboard UI", DurationMinutes = 50, Category = "Development", CompletedTimeAgo = "32m ago", SessionType = "Focus", IconColor = "#635BFF" },
                new() { Id = 102, Title = "Quick Sprint: Code Review & Bug Triage", DurationMinutes = 25, Category = "Review", CompletedTimeAgo = "2h ago", SessionType = "Focus", IconColor = "#10B981" },
                new() { Id = 103, Title = "Calm Reading & Architecture Notes", DurationMinutes = 20, Category = "Study", CompletedTimeAgo = "4h ago", SessionType = "Focus", IconColor = "#F59E0B" }
            }
        };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
