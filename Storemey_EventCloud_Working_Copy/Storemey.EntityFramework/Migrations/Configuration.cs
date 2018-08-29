using System.Data.Entity.Migrations;
using Storemey.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Storemey.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Storemey.EntityFramework.StoremeyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Storemey";
        }

        protected override void Seed(Storemey.EntityFramework.StoremeyDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
