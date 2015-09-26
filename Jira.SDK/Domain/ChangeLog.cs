using System.Collections.Generic;

namespace Jira.SDK
{
    public class IssueChangeLogResult
    {
        public ChangeLog ChangeLog { get; set; }
    }

    public class ChangeLog
    {
        public int StartAt { get; set; }
        public int MaxResults { get; set; }
        public int Total { get; set; }
        public List<History> Histories { get; set; }
    }

    public class History
    {
        public string Id { get; set; }
        public User Author { get; set; }
        public string Created { get; set; }
        public List<HistoryItem> Items { get; set; }
    }

    public class HistoryItem
    {
        public string Field { get; set; }
        public string Fieldtype { get; set; }
        public string From { get; set; }
        public string FromString { get; set; }
        public string To { get; set; }
        public new string ToString { get; set; }
    }
}