using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolStudent.Models
{
    public enum Attendance
    {
        Compliant = 1,
        NonCompliant = 2
    }
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int RollNumber { get; set; }
        public string FullName { get; set; }
        public int AttendanceId { get; set; }

        [NotMapped]

        public Attendance Attendance
        {
            get { return (Attendance)this.AttendanceId; }
            set { this.AttendanceId = (int)value; }
        }
        //public string Attendance { get; set; }
        public string DivisionId { get; set; }
        public string Standard { get; set; }
        public double GPA { get; set; }
        public string DateOfBirth { get; set; }
        public string IsActive { get; set; }
        public Division division { get; set; }
    }
    

    
}
