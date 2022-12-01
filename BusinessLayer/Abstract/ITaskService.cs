using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITaskService
    {

        public int AddTask(TaskTable task);
        public int UpdateTask(TaskTable task);
        public int DeleteTask(TaskTable task);

        List<TaskTable> ListAllTasks(Expression<Func<TaskTable, bool>> filter = null);

        TaskTable GetById(int id);
    }
}
