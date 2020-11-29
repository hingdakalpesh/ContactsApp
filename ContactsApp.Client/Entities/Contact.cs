using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApp.Client.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        //Personal data
        [Required(ErrorMessage = "First name is required.")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }

        public string Avtar { get; set; }

        public string Domain { get; set; }

        public string Notes { get; set; }

        //Company data
        public string Company{ get; set; }
        public string Logo { get; set; }
        public string JobTitle { get; set; }
        public string Industry { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }
}
