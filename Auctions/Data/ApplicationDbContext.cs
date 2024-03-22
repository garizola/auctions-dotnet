using Auctions.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Auctions.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Listing> Listings { get; set; }
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Comment> Comments { get; set; }
}

