using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Data
{
    internal class PersonInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Persons.AddRange(SeederHelper.CreateInitialListOfPerson());
            base.Seed(context);
        }
    }
}
