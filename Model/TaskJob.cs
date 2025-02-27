using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class TaskJob : IComparable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String Note { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }  
        public TaskJob(int userId)
        {
            this.UserId = userId;
        }
       public TaskJob(int UserId, string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            this.TaskName = taskName;
            this.Description = description;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Note = note;
            this.Priority = priority;
            this.Status = status;
            this.UserId = UserId;
        }
        public TaskJob() { }

        public int CompareTo(object obj)
        {
            if(this.Priority < this.Priority)
                return -1;
            else if (this.Priority == this.Priority)
                return 0;
            else
                return 1;
        }
    }
}
