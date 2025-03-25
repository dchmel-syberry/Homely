using Homely.Infrastructure.Data.Entities;
using Homely.Infrastructure.Data.Entities.Rbac;
using Microsoft.EntityFrameworkCore;

namespace Homely.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }
}