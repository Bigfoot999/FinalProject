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

     

        public TaskJob CreateTask(int UserId ,string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
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
        public List<TaskJob> findByUserId(int id)
        {
            List<TaskJob> newLs = new List<TaskJob>();
            foreach (TaskJob task in lsTask)
            {
                if (task.UserId == id)
                {
                    newLs.Add(task);
                }
            }
            return newLs;
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

        public List<TaskJob> findByPriority(int  pro )
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
        public void sortByPriority()
        {
            lsTask.Sort();
        }

        internal TaskJob updateTask(int id, string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            foreach(TaskJob task in lsTask)
            {
                if (task.Id == id)
                {
                    task.TaskName = taskName;
                    task.Description = description;
                    task.StartTime = startTime;
                    task.EndTime = endTime;
                    task.Note = note;
                    task.Priority = priority;
                    task.Status = status;
                    return task;
                }
            }
            return null;
        }

        public String deleteTask(int id)
        {
            foreach(TaskJob task in lsTask)
            {
                if (task.Id == id)
                {
                    lsTask.Remove(task);
                    return "Xóa thành công";
                }
            }
            return "Không tìm thấy Task";
        }

        public string updateTaskStatus(int id, string status)
        {
            foreach (TaskJob task in lsTask)
            {
                if (task.Id == id)
                {
                    task.Status = status;
                    return "Cập nhật thành công";
                }
            }
            return "Không tìm thấy Task";
        }
    }


    
}
