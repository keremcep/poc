using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using poc.Authorization.Roles;
using poc.Authorization.Users;
using poc.MultiTenancy;

namespace poc.EntityFrameworkCore
{
    public class pocDbContext : AbpZeroDbContext<Tenant, Role, User, pocDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public pocDbContext(DbContextOptions<pocDbContext> options)
            : base(options)
        {
        }
    }
}
