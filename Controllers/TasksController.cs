using Microsoft.AspNetCore.Mvc;
using FocusFlow.Models;
using FocusFlow.ViewModels;

namespace FocusFlow.Controllers;

public class TasksController : Controller
{
    public IActionResult Index(string tab = "All")
    {
        var model = new TasksViewModel
        {
            ActiveTab = tab,
            Metrics = new TaskMetricSummary
            {
                LowPriorityCount = 42,
                MedPriorityCount = 64,
                HighPriorityCount = 12,
                TotalTaskCount = 120,
                TotalTaskDoneCount = 220,
                OverdueCount = 28
            },
            Tasks = new List<TaskItem>
            {
                new() { Id = 1, Title = "Classroom Documentation & Setup", AssignedName = "Rizky Kurniawan", AssignedAvatar = "RK", Priority = "Medium", Status = "Overdue", DueDate = "10 Feb, 2026", SubtasksCount = 1, IsCompleted = false },
                new() { Id = 2, Title = "Progress Update & Stakeholder Sync", AssignedName = "Sophia Bennett", AssignedAvatar = "SB", Priority = "High", Status = "Overdue", DueDate = "10 Feb, 2026", SubtasksCount = 2, IsCompleted = false },
                new() { Id = 3, Title = "Parent Communication & Quarterly Review", AssignedName = "Taufik Hidayat", AssignedAvatar = "TH", Priority = "Medium", Status = "Overdue", DueDate = "11 Feb, 2026", SubtasksCount = 3, IsCompleted = false },
                new() { Id = 4, Title = "Student Well-being Monitoring System", AssignedName = "Yahyo Prayogo", AssignedAvatar = "YP", Priority = "Low", Status = "Todo", DueDate = "16 Feb, 2026", SubtasksCount = 4, IsCompleted = false },
                new() { Id = 5, Title = "Prepare & Review Lesson Plans", AssignedName = "Taufik Hidayat", AssignedAvatar = "TH", Priority = "Low", Status = "Todo", DueDate = "16 Feb, 2026", SubtasksCount = 2, IsCompleted = false },
                new() { Id = 6, Title = "Preparatory Material & Lab Worksheets", AssignedName = "Aditya Irawan", AssignedAvatar = "AI", Priority = "Medium", Status = "Todo", DueDate = "18 Feb, 2026", SubtasksCount = 1, IsCompleted = false },
                new() { Id = 7, Title = "Collaborative Planning with Other Teachers", AssignedName = "Amanda Nur", AssignedAvatar = "AN", Priority = "Medium", Status = "Doing", DueDate = "13 Feb, 2026", SubtasksCount = 4, IsCompleted = false },
                new() { Id = 8, Title = "Implementation of Hybrid Learning Platform", AssignedName = "Sophia Bennett", AssignedAvatar = "SB", Priority = "Low", Status = "Doing", DueDate = "13 Feb, 2026", SubtasksCount = 1, IsCompleted = false },
                new() { Id = 9, Title = "Assessment & Diagnostic Feedback", AssignedName = "Amanda Nur", AssignedAvatar = "AN", Priority = "High", Status = "Doing", DueDate = "14 Feb, 2026", SubtasksCount = 2, IsCompleted = false },
                new() { Id = 10, Title = "Grade & Record Midterm Assessments", AssignedName = "Amanda Nur", AssignedAvatar = "AN", Priority = "High", Status = "Doing", DueDate = "15 Feb, 2026", SubtasksCount = 4, IsCompleted = false },
                new() { Id = 11, Title = "Curriculum Alignment & Standard Mapping", AssignedName = "Aditya Irawan", AssignedAvatar = "AI", Priority = "Medium", Status = "Completed", DueDate = "08 Feb, 2026", SubtasksCount = 2, IsCompleted = true },
                new() { Id = 12, Title = "Attend Internal Briefing or Check-ins", AssignedName = "Rizky Kurniawan", AssignedAvatar = "RK", Priority = "Low", Status = "Completed", DueDate = "08 Feb, 2026", SubtasksCount = 3, IsCompleted = true }
            }
        };

        return View(model);
    }
}
