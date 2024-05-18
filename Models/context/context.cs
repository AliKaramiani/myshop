

using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Crud> Tbl_OnlineShop { get; set; }
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=eiger.liara.cloud,31508;Initial Catalog=MyShopDb;User Id=sa;Password=z5Y0vidaGciDckNqm7xRmgCB;MultipleActiveResultSets=true;TrustServerCertificate=true");

    }



}