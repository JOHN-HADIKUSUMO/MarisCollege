using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarisCollege.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Student(int id,string fullname,string email,string mobile,string gender,DateTime dob)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.Email = email;
            this.Mobile = mobile;
            this.Gender = gender;
            this.DOB = dob;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}
