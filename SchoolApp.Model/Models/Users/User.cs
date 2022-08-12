using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Model.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string MeliCode { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string EducationLevel { get; set; }
        public string FieldOfStudy { get; set; }
        public string Job { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        //public IFormFile Picture { get; set; }
        public bool IsActive { get; set; } = true;


        #region relationships

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Manager Manager { get; set; }

        #endregion

    }
}
