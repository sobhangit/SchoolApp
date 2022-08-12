﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Model.Models
{
    public class Paye
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Class> Classes { get; set; }
    }
}
