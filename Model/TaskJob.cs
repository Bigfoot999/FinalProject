using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class TaskJob
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String Note { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
       public TaskJob(string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            this.TaskName = taskName;
            this.Description = description;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Note = note;
            this.Priority = priority;
            this.Status = status;
        }
        public TaskJob() { }
    }
}
