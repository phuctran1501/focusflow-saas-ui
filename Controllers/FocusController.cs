using Microsoft.AspNetCore.Mvc;
using FocusFlow.Models;
using FocusFlow.ViewModels;

namespace FocusFlow.Controllers;

public class FocusController : Controller
{
    public IActionResult Index()
    {
        var model = new FocusViewModel
        {
            FocusMinutes = 25,
            ShortBreakMinutes = 5,
            LongBreakMinutes = 15,
            CurrentTaskTitle = "Review Q3 goals & architecture design",
            CompletedSessionsToday = 4,
            TotalTargetSessions = 8,
            FocusTasks = new List<TaskItem>
            {
                new() { Id = 1, Title = "Review Q3 goals & core metrics", Priority = "High", Status = "Doing", IsCompleted = false },
                new() { Id = 2, Title = "Email marketing team feedback", Priority = "Medium", Status = "Todo", IsCompleted = false },
                new() { Id = 3, Title = "Update landing page copy & value prop", Priority = "Low", Status = "Todo", IsCompleted = false },
                new() { Id = 4, Title = "Resolve Github PR review comments", Priority = "High", Status = "Completed", IsCompleted = true }
            },
            DayStructures = new List<DayStructure>
            {
                new() { Title = "Deep Work", Description = "Newport style: 4h uninterrupted intense focus", IconColor = "#3B82F6", Badge = "4h blocks", IsActive = true },
                new() { Title = "Study Mode", Description = "50/10 intervals for optimal memory retention", IconColor = "#10B981", Badge = "50/10m", IsActive = false },
                new() { Title = "Power Day", Description = "High output, fast-paced sprint pomodoros", IconColor = "#F97316", Badge = "25/5m", IsActive = false }
            },
            AmbientSounds = new List<SoundPreset>
            {
                new() { Id = "rain", Name = "Gentle Rain", Icon = "🌧️", IsActive = true },
                new() { Id = "waves", Name = "Alpha Waves", Icon = "🌊", IsActive = false },
                new() { Id = "forest", Name = "Pine Forest", Icon = "🌲", IsActive = false },
                new() { Id = "cafe", Name = "Cozy Cafe", Icon = "☕", IsActive = false }
            }
        };

        return View(model);
    }
}
