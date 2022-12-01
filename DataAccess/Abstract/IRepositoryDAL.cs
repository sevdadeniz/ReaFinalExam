using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepositoryDAL<T>
    {
        public int Add(T t);
        public int Delete(T t);
        public int Update(T t);

        List<T> ListAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
    }
}
