using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Forum.Models;

namespace Forum.DataAccessLayer
{
    public class DbCtx:DbContext
    {
        public DbCtx() : base("DB")
        {

            Database.SetInitializer<DbCtx>(new Initp());
            //Database.SetInitializer<DbCtx>(new CreateDatabaseIfNotExists<DbCtx>());
        }
       
        public DbSet<Question>Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}