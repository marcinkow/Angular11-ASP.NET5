﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string EmployeeName { get; set; }
        public string TranType { get; set; }
    }
}