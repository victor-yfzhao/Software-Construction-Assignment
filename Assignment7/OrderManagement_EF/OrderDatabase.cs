using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace OrderManagement_EF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderDatabase : DbContext
    {
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<OrderDetail> Details { get; set; }
        public  DbSet<Item> Items { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        
        public OrderDatabase()
            : base("name=OrderDatabase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderDatabase>());
        }
    }
}