using FocusFlow.Models;

namespace FocusFlow.ViewModels;

public class DayStructure
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IconColor { get; set; } = "#3B82F6";
    public string Badge { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}

public class SoundPreset
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}

public class FocusViewModel
{
    public int FocusMinutes { get; set; } = 25;
    public int ShortBreakMinutes { get; set; } = 5;
    public int LongBreakMinutes { get; set; } = 15;
    public string CurrentTaskTitle { get; set; } = "Review Q3 goals & architecture design";
    public int CompletedSessionsToday { get; set; } = 4;
    public int TotalTargetSessions { get; set; } = 8;
    
    public List<TaskItem> FocusTasks { get; set; } = new();
    public List<DayStructure> DayStructures { get; set; } = new();
    public List<SoundPreset> AmbientSounds { get; set; } = new();
}
