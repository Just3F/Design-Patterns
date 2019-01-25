namespace DesignPatterns.Models
{
    public class LogEntry
    {
        public string Message { get; set; }
        public LogType LogType { get; set; }
    }

    public enum LogType
    {
        Warning,
        Error,
        Info
    }
}
