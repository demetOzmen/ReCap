﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerAddDto
    {
        public string UserFirstName { get; set; }
        public string UserEmail { get; set; }
        public string UserLastName { get; set; }
        public string UserPassword { get; set; }
        public string CustomerCompanyName { get; set; }
    }
}
