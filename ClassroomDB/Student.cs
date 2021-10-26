using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassroomDB
{
    class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Food { get; set; }
        public string Hometown { get; set; }

    }
}
