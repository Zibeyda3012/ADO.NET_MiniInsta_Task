using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_MiniInsta_Task
{
    public class MiniInstaContext: DbContext
    {
        public DbSet<Tag> Tags { get; set;}
        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set;}

        public MiniInstaContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MiniInsta;Integrated Security=SSPI;");
        }
    }
}
