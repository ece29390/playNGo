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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required,MaxLength(50)]
        public string LastName { get; set; }

        [Required,MaxLength(50)]
        public string PhoneNumber { get; set; }
    }
}
