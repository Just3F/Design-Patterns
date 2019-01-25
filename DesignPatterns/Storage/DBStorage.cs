using System.Collections.Generic;
using DesignPatterns.Models;

namespace DesignPatterns.Storage
{
    public class DbStorage
    {
        public IEnumerable<LogEntry> LogEntries => new List<LogEntry>()
        {
            new LogEntry { Message = "Something went wrong!", LogType = LogType.Error },
            new LogEntry { Message = "All are working good now.", LogType = LogType.Info },
            new LogEntry { Message = "Something bad happened! Error 404", LogType = LogType.Error },
            new LogEntry { Message = "Please be careful", LogType = LogType.Warning }
        };
    }
}
