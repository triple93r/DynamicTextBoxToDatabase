﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class stdVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public List<tblStudent> Students { get; set; }
    }
}
