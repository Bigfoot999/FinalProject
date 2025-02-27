
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
        public TaskJob CreateTask(int UserId,string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            return taskRepository.CreateTask(UserId,taskName, description, startTime, endTime, note, priority, status);
        }
        public TaskJob findById(int id)
        {
            return taskRepository.findById(id);
        }

        

        public List<TaskJob> findByUserId(int id, TaskRepository taskRepository)
        {
            return taskRepository.findByUserId(id);
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
        public TaskJob updateTask(int id, string taskName, string description, DateTime startTime, DateTime endTime, string note, int priority, string status)
        {
            if (taskRepository.findById(id) != null)
            {
                Console.WriteLine("Không tìm thấy Task");
                return null;
            }

            return taskRepository.updateTask(id, taskName, description, startTime, endTime, note, priority, status);
        }
        public String deleteTask(int id)
        {
            return taskRepository.deleteTask(id);
        }
        public String updateTaskStatus(int id, string status)
        {
            return taskRepository.updateTaskStatus(id, status);
        }

    }
}
