using Microsoft.AspNetCore.Mvc;
using FocusFlow.ViewModels;

namespace FocusFlow.Controllers;

public class InsightsController : Controller
{
    public IActionResult Index()
    {
        var model = new InsightsViewModel
        {
            ProductivityScore = 84.2,
            ScoreTrend = "↑ 12%",
            StreakDays = 12,
            TopPercentile = 5,
            CompletedTasksCount = 142,
            PendingTasksCount = 25,
            CompletionRate = 85,
            WeeklyFocusHours = 28.4,
            Insights = new List<InsightCard>
            {
                new()
                {
                    Title = "Peak Focus",
                    Description = "Your focus peak is usually at 10:00 AM. Schedule deep work then.",
                    IconType = "lightning",
                    IconBg = "#EEEDFF",
                    IconColor = "#635BFF"
                },
                new()
                {
                    Title = "Consistency King",
                    Description = "You haven't missed a daily goal in 8 days. Keep up the momentum!",
                    IconType = "trending",
                    IconBg = "#E6FBF0",
                    IconColor = "#10B981"
                },
                new()
                {
                    Title = "Rest Insight",
                    Description = "Late night work sessions decreased by 15% this week. Better recovery!",
                    IconType = "moon",
                    IconBg = "#F3EDFF",
                    IconColor = "#8B5CF6"
                }
            }
        };

        return View(model);
    }
}
