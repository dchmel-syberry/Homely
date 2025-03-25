using Homely.Data.Entities;
using Homely.Data.Entities.Rbac;
using Microsoft.EntityFrameworkCore;

namespace Homely.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }
}