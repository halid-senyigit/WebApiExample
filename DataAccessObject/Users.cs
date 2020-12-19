using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessObject
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
