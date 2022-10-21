
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
        public DbSet<User> Users { get; set; }
      
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }  
        public DbSet<Supply> Supplies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         


            modelBuilder.Entity<User>().HasOne(x => x.Account_Id).WithOne().OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Role>().HasData(new Role {
                Id_Role=1, Role_Name="Логист"}
                ) ;
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id_Role = 2,
                Role_Name = "Администратор"
            }
                );

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id_Role = 3,
                Role_Name = "Поставщик"
            }

    );
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id_Role = 4,
                Role_Name = "Кладовщик"
            }
    );
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id_Role = 5,
                Role_Name = "Курьер"
            }
    );
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id_Role = 6,
                Role_Name = "Клиент"
            }
    );
            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id_Account = 1,
                Login = "PepegaLord",
                Password = "5f013368646b4c48d66a7df4ee89d1cfcd8928b9aadf69dcbd05170604666289"
            });
            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    Id_User= 1,
            //    Surname= "Великов",
            //    Name= "Василий",
            //    Patronymic= "Жмадонович",
            //    Series_Passport= "7135",
            //    Number_Passport="812731",
            //    Role_Id= 2,
            //    Email="oof@mail.ru",
            //    Phone_Number= "+7(941)919-32-41"
            //});

            modelBuilder.Entity<User>().HasCheckConstraint("CheckPhoneNumber","Phone_Number like '+[7-8]([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]'");
            modelBuilder.Entity<User>().HasIndex(x=>x.Phone_Number).IsUnique();
            modelBuilder.Entity<Account>().HasIndex(x => x.Login).IsUnique();
            modelBuilder.Entity<User>().HasCheckConstraint("CheckEmail", "Email like '%@%.%'");
            


        }
        public DbSet<Account> Account { get; set; }
        public DbSet<OrderClient> OrderClient { get; set; }
        public DbSet<BridgesCoModels.Models.Pathing> Pathing { get; set; }


     
    }
    
}
