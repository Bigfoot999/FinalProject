
using System;
using System.Threading.Tasks;
using FinalProject.Repository;
using FinalProject.Model;
using System.Collections.Generic;
namespace FinalProject.Controller
{
    public class TaskController
    {
        public TaskRepository taskRepository;
        public TaskController() { 
            taskRepository = new TaskRepository();
        }
        public TaskJob CreateTask(string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            return taskRepository.CreateTask(taskName, description, startTime, endTime, note, priority, status);
        }
        public TaskJob findById(int id)
        {
            return taskRepository.findById(id);
        }
        public List<TaskJob> findByName(string name)
        {
            return taskRepository.findByName(name);
        }
        public List<TaskJob> getAll()
        {
            return taskRepository.lsTask;
        }
        public List<TaskJob> findByPriority(int priority)
        {
            return taskRepository.findByPriority(priority);
        }
    }
}
