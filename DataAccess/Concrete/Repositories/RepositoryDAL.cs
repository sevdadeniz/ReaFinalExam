using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class RepositoryDAL<T> : IRepositoryDAL<T> where T : class
    {
        Context _context = new Context();
        DbSet<T> obj;
        public RepositoryDAL()
        {
           obj=_context.Set<T>();
        }



        public int Add(T t)
        {
            obj.Add(t);
            return _context.SaveChanges();
        }

        public int Delete(T t)
        {
            obj.Remove(t);
            return _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter = null)
        {
            return obj.ToList();
        }

        public int Update(T t)
        {
            obj.Update(t);
            return _context.SaveChanges();
        }
    }
}
