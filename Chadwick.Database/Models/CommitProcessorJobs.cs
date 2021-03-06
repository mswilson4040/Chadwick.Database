using System;
using System.ComponentModel.DataAnnotations;

namespace Chadwick.Database.Models
{
    public class CommitProcessorJobs
    {
        [Key]
        public int CommitId { get; set; }
        public string CommitHash { get; set; }
        public DateTime Started { get; set; }
        public string Status { get; set; }
        public int FilesToProcessCount { get; set; }
        public DateTime Finished { get; set; }
        public int CompletedCount { get; set; }
        public int FailCount { get; set; }

        public CommitProcessorJobs()
        {
            Started = DateTime.UtcNow;
        }
    }
}