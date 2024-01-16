﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public int StaffID { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? ContactInfo { get; set; }

        public string? EmailAddress { get; set; }

        public string? FirstName { get; set;}

        public string? LastName { get; set;}


    }
}