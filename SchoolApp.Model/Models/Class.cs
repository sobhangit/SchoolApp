using SchoolApp.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Model.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int PayeId { get; set; }
        public Paye Paye { get; set; }

        public ICollection<Student> Students { get; set; }

        
    }
}
