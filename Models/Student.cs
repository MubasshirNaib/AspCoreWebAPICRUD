﻿using System.ComponentModel.DataAnnotations;

namespace AspCoreWebAPICRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
