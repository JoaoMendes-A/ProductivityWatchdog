public class FocusRule
{
    public int Id { get; set; }

    public string RuleName { get; set; } = string.Empty;

    public string TargetApplication { get; set; } = string.Empty;

    public int TimeThresholdInMinutes { get; set; }

    public bool AlertEnabled { get; set; }

    public bool AutoBlockEnabled { get; set; }

    public bool IsActive { get; set; }
}