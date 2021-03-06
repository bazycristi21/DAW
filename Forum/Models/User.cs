﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The passwords are not the same.")]
        public string ConfirmPassword { get; set; }
    }
}