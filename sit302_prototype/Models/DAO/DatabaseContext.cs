using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO {
    public class DatabaseContext : DbContext {
        private static DatabaseContext instance;

        public static DatabaseContext getInstance() {
            if (instance == null) {
                instance = new DatabaseContext();
            }

            return instance;
        }

        public DbSet<Course> courseContext { get; set; }
        public DbSet<Major> majorContext { get; set; }
        public DbSet<Unit> unitContext { get; set; }
        public DbSet<Offered> offeredContext { get; set; }
        public DbSet<Plan> planContext { get; set; }
        public DbSet<PlanUnitGrid> gridContext { get; set; }
        public DbSet<GridEntry> entryContext { get; set; }
    }
}