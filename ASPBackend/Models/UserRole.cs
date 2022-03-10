﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ASPBackend.Models
{
    public class UserRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        IEnumerable<User> Users { get; set; }
        public UserRole()
        {
            Users = new List<User>();
        }
    }
}