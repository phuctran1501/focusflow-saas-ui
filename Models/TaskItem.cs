namespace FocusFlow.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = "General";
    public string Priority { get; set; } = "Medium"; // "High", "Medium", "Low"
    public string Status { get; set; } = "Todo"; // "Todo", "Doing", "Completed", "Overdue"
    public string DueDate { get; set; } = string.Empty;
    public string AssignedName { get; set; } = "Alex Morgan";
    public string AssignedAvatar { get; set; } = "AM";
    public int SubtasksCount { get; set; } = 3;
    public bool IsCompleted { get; set; }
}
