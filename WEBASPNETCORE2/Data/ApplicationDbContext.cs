using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WEBASPNETCORE2.Models;
namespace WEBASPNETCORE2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Se especifican las tablas que desean migrarse con CODE FIRST
        public DbSet<TablaPrueba> TablaPrueba { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Seed();
        }
    }
}
