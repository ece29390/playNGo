using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Data
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.PhoneNumber)
                .HasMaxLength(50)
                .IsRequired();
        }

       
        
    }
}
