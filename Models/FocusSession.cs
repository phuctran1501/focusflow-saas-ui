namespace FocusFlow.Models;

public class FocusSession
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int DurationMinutes { get; set; } = 25;
    public string Category { get; set; } = "Deep Work";
    public string CompletedTimeAgo { get; set; } = string.Empty;
    public string SessionType { get; set; } = "Focus"; // "Focus", "ShortBreak", "LongBreak"
    public string IconColor { get; set; } = "#635BFF";
}
