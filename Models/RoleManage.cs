﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CenedexUniversityWebSystem.Models
{
    public class RoleManage
    {
        [Required]
        public string RoleName { get; set; }
    }
}
