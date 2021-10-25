using Microsoft.EntityFrameworkCore;
using PreAceleracion_DesafioUno.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAceleracion_DesafioUno.Context
{
    public class SocialMedia : DbContext
    {
        private const string Schema = "Socialmedia";

        public SocialMedia(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\\MSSQLLocalDB; Database = socialmediaDB; Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);

            //modelBuilder.Entity<User>().HasData(
            //    new User()
            //    {
            //        Id = 1,
            //        Name = "Admin",
            //        Password = "1234",
            //        Email = "admin@user.com"
            //    });

        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
    }
}
