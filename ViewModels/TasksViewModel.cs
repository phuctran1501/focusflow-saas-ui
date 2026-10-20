using FocusFlow.Models;

namespace FocusFlow.ViewModels;

public class TaskMetricSummary
{
    public int LowPriorityCount { get; set; } = 42;
    public int MedPriorityCount { get; set; } = 64;
    public int HighPriorityCount { get; set; } = 12;
    public int TotalTaskCount { get; set; } = 120;
    public int TotalTaskDoneCount { get; set; } = 220;
    public int OverdueCount { get; set; } = 28;
}

public class TasksViewModel
{
    public string ActiveTab { get; set; } = "All";
    public TaskMetricSummary Metrics { get; set; } = new();
    public List<TaskItem> Tasks { get; set; } = new();
}
