using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PhonebookAut.Models
{
    public class Contact
    {

        public int Id { get; set; }
        

        [Required(ErrorMessage = "Name is a required field!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The {0} must be between {2} and {1} chars.")]
        public string name { get; set; }
        [StringLength(20)]
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Only numbers and white-space are allowed.")]
        public string Phone { get; set; }
        [StringLength(40)]
        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateOfBirth { get; set; }
        public int Age { get; set; }
    }

    public class ContactsDbContext : DbContext {
            public DbSet<Contact> Contacts { get; set; }
        }
}