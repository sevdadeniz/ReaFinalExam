using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=SEVDENIZ;Database=TaskMan;Trusted_Connection=true");
        }

        public DbSet<TaskTable> TaskTables { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
