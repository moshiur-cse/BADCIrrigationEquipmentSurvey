using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using BADCIrrigationEquipmentSurvey.Models;


namespace BADCIrrigationEquipmentSurvey.DbContexts
{
    public class UserDbContext : IdentityDbContext<BadcAppUser>
    {
        public virtual DbSet<BadcAppUser> BadcAppUseres { get; set; }
        //public DbSet<BadcAppUser> MyBadcAppUser { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BadcAppUser>().ToTable("TblUsers");
        }
    }



    //public class MyBadcAppUser : BadcAppUser
    //{
    //    public virtual BadcAppUser BadcAppUser { get; set; }
    //}

    //public class BadcAppUser
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}
    //public class MyDbContext : IdentityDbContext<MyBadcAppUser>
    //{
    //    public MyDbContext() : base("DefaultConnection") { }
    //    public System.Data.Entity.DbSet<BadcAppUser> MyBadcAppUser { get; set; }
    //}

}
