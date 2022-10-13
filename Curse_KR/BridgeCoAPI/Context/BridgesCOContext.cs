
using BridgesCoModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BridgesCoModels.Context
{
    public class BridgesCOContext :DbContext
    {
        public BridgesCOContext(Microsoft.EntityFrameworkCore.DbContextOptions<BridgesCOContext> options) : base(options)
        {
            
        }
        
        public DbSet<Role> Roles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }  
        public DbSet<Supply> Supplies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Role>().HasData(new Role { Id_Role = 1, Role_Name = "Поставщик" });
            modelBuilder.Entity<Role>().HasData(new Role { Id_Role = 2, Role_Name = "Логист" });
            modelBuilder.Entity<Role>().HasData(new Role { Id_Role = 3, Role_Name = "Курьер" });
            modelBuilder.Entity<Role>().HasData(new Role { Id_Role = 4, Role_Name = "Кладовщик" });
            modelBuilder.Entity<Role>().HasData(new Role { Id_Role = 5, Role_Name = "Клиент" });
            modelBuilder.Entity<Role>().HasData(new Role { Id_Role = 6, Role_Name = "Администратор" });
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<OrderClient> OrderClient { get; set; }


     
    }
    
}
