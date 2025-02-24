using System;
using System.Collections.Generic;

using FinalProject.Model;

namespace FinalProject.Repository
{
    public class TaskRepository
    {
        public List<TaskJob> lsTask;
        protected int id = 2000;
        public TaskRepository()
        {
            this.lsTask = new List<TaskJob>();
        }
        public TaskJob CreateTask(string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            TaskJob task = new TaskJob(taskName, description, startTime, endTime,note, priority, status);
            id++;
            lsTask.Add(task);
            return task;
        }

        public TaskJob findById(int id)
        {
            foreach (TaskJob task in lsTask)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }
            return null;
        }

        public List<TaskJob> findByName(string name)
        {
            List<TaskJob> newLs = new List<TaskJob>();
            foreach (TaskJob task in lsTask)
            {
                if (task.TaskName.Contains(name))
                {
                    newLs.Add(task);
                }
            }
            return newLs;
        }

        internal List<TaskJob> findByPriority(int  pro )
        {
            List<TaskJob> newLs = new List<TaskJob>();
            foreach (TaskJob task in lsTask)
            {
                if (task.Priority == pro)
                {
                    lsTask.Add(task);
                }
            }
            return newLs;
        }
    }

    
}
