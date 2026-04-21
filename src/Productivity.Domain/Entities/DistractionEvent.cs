public class DistractionEvent
{
    public int Id { get; set; }
    public string ApplicationName  { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan Duration => EndTime - StartTime;
    public EventType EventType { get; set; }
    public SeverityLevel SeverityLevel { get; set; }
    public int FocusSessionId { get; set; }
}