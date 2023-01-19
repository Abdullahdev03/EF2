using Domain.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options)
  {
    
  }

  public DbSet<Customer> Customers { get; set; }
  public DbSet<Order> Orders { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<OrderDetail> OrderDetails { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
/*
      modelBuilder.Models<Customer>().HasData(
          new List<Customer>()
          {
              new Customer(1, "Ardasher", "Sattori", "Dushanbe", "881933339", "ardasher@icloud.com"),
              new Customer(2, "Abdullah", "Sheralizoda", "Asht", "000000000", "abdullah@gmail.com"),
              new Customer(3, "Anushervon", "Bekov", "Kulob", "000000000", "anushervon@gmail.com"),
              new Customer(4, "Sherzod", "Ishankulov", "Dushanbe", "000000000", "sherzod@gmail.com"),
          });*/
          base.OnModelCreating(modelBuilder);
  }
}