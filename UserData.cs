using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogin
{
    public class UserData : DbContext
    {
        //overriding onconfiguring to tell the app about the database file, we need to manually add user entries at this point
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataFile.db");
        }
        public DbSet<User> Users { get; set; }
    }
}
