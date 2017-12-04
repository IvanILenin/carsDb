namespace Cars.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cars.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cars.Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Manufacturers.AddOrUpdate(item => item.id, new Manufacturer() { Country = "Russia", Name = "Ivan" });
            context.Manufacturers.AddOrUpdate(item => item.id, new Manufacturer() { Country = "USA", Name = "Bob" });
            context.Manufacturers.AddOrUpdate(item => item.id, new Manufacturer() { Country = "Germany", Name = "Bob2" });            
            

            context.Manufacturers.AddOrUpdate(item => item.id, new Manufacturer() { Country = "Snezhinsk", Name = "Gena" });
            context.Manufacturers.AddOrUpdate(item => item.id, new Manufacturer() { Country = "Italy", Name = "Fabio" });
        }
    }
}
