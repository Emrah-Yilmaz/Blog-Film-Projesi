using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole, int> 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\;database=FinalProject; integrated security=true;");

           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
       public DbSet<BlogRating> BlogRatings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SubsCategory> SubsCategories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<InboxInfo> InboxInfos { get; set; }
        public DbSet<Message> Messages { get; set; }
        
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<CategoryVm> categoryVms { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Rating> Ratings { get; set; }


    }
}
