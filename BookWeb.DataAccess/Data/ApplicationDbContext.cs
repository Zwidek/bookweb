﻿using BookWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookWeb.Models.ViewModels;

namespace BookWeb.DataAccess;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<CoverType> CoverTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<OrderHeader> OrderHeaders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }


}
