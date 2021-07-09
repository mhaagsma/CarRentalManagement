﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        [Required]
        [StringLength(25, MinimumLength = 2)] 
        public string Name { get; set; }
 
    }
}
