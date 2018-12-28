using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily
{
    public class DailyDB : DbContext
    {

        public DailyDB() : base("DailyDataBase") { }
        public DbSet<DailyEntity> DailyEntity { get; set; }
        public DbSet<WorkEntity> WorkEntity { get; set; }
        public DbSet<TaskEntity> TaskEntity { get; set; }
    }
}
