using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Model.Models.Users
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }

        public User User { get; set; }
        public Class Class { get; set; }

    }
}
