﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cover Type")]
        [Required]
        [MaxLength(50)]
        public int Name { get; set; }

    }
}
