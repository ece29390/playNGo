using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Models
{
    public class Person
    {
       
        public Guid Id { get; set; }

        
        public string FirstName { get; set; }

    
        public string LastName { get; set; }

      
        public string PhoneNumber { get; set; }
    }
}
