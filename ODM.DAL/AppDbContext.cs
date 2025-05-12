using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ODM.DAL
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public AppDbContext() : base("name=MyConn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map DbSet<Item> Items to the "Item" table
            modelBuilder.Entity<Item>().ToTable("Item");
           
            modelBuilder.Entity<Agent>().ToTable("Agent");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail");
        }
    }
}
