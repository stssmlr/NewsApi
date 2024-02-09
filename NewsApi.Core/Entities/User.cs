﻿using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewsApi.Core.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public int RoleId { get; set; }
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Phone]
        public string Phone { get; set; } = string.Empty;

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
            }
        }
    }
}
