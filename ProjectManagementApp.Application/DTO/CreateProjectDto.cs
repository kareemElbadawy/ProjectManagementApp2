﻿using ProjectManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.Application.DTO
{
    public class CreateProjectDto
    {
        [Required]
        [StringLength(100)]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Budget { get; set; }

        public string Owner { get; set; }

        public ProjectStatus Status { get; set; }
    }
}
