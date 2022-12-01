
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Repositories
{
    public class TaskDAL:RepositoryDAL<TaskTable>,ITaskDAL
    {
    }
}
