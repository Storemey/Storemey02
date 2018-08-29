using Storemey.EntityFramework;

namespace Storemey.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly StoremeyDbContext _context;

        public InitialDataBuilder(StoremeyDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
        }
    }
}
