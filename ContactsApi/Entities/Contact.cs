using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        //Personal data
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public string Domain { get; set; }
        public string Notes { get; set; }
        public string Avtar { get; set; }

        //Company data
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string Logo { get; set; }
        public string Industry { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }
}
