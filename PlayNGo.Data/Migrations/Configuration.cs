namespace PlayNGo.Data.Migrations
{
    using PlayNGo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlayNGo.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlayNGo.Data.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var persons = new List<Person>
            {
                new Person{FirstName="Stephen",LastName="Curry",PhoneNumber="(508) 972-3449" }
                ,new Person{FirstName="Kevin", LastName="Durant",PhoneNumber="(348) 934-7082"}
                ,new Person{FirstName="Draymond", LastName="Green", PhoneNumber="(882) 616-2107" }
            };
            context.Persons.AddRange(persons);
        }
    }
}
