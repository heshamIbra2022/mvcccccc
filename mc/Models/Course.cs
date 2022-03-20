using System;

namespace mc.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level_Id { get; set; }
        public DateTime  Date { get; set; }

        public int User_Id { get; set; }


    }
}
