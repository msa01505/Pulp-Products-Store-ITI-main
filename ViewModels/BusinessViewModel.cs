﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pulp.ViewModels
{
    public class BusinessViewModel
    {
        public int BusinessID { set; get; }

        [Required]
        public string Name { set; get; }
        [Required]
        [MaxLength(50, ErrorMessage = "Describtion can't be more than 50 characters")]
        public string Describtion { set; get; }


        [Required]
        public IFormFile Image { get; set; }
    }
}
