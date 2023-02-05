using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesktopContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
/*        [Required]*/
        public string Name { get; set; }
/*        [Required]
        [EmailAddress]*/
        public string Email { get; set; }
/*        [Required]
        [Phone]*/
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
