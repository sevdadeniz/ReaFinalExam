using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class TaskMan : ITaskService
    {
        ITaskDAL taskDAL;

        public TaskMan(ITaskDAL taskDAL)
        {
            this.taskDAL = taskDAL;
        }

        public int AddTask(TaskTable task)
        {
            return taskDAL.Add(task);
        }

        public int DeleteTask(TaskTable task)
        {
            return taskDAL.Delete(task);
        }

        public TaskTable GetById(int id)
        {
            return taskDAL.GetById(id);
        }

        public List<TaskTable> ListAllTasks(Expression<Func<TaskTable, bool>> filter = null)
        {
            return taskDAL.ListAll();
        }

        public int UpdateTask(TaskTable task)
        {
           return taskDAL.Update(task);
        }
    }
}
