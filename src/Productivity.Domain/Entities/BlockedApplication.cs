public class BlockedApplication
{
    public int Id { get; private set; }

    public string DisplayName { get; private set; }

    public string ProcessName { get; private set; }

    public AppCategory Category { get; private set; }

    public bool AutoBlockEnabled { get; private set; }

    public BlockedApplication(
        string displayName,
        string processName,
        AppCategory category,
        bool autoBlockEnabled = false)
    {
        if (string.IsNullOrWhiteSpace(displayName))
            throw new ArgumentException("Display name is required.");

        if (string.IsNullOrWhiteSpace(processName))
            throw new ArgumentException("Process name is required.");

        DisplayName = displayName;
        ProcessName = processName.ToLower();
        Category = category;
        AutoBlockEnabled = autoBlockEnabled;
    }
}