﻿using System.ComponentModel.DataAnnotations;
namespace Task_Management.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
    }
}