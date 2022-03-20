using System;

namespace mc.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int Degree { get; set; }
        public int Course_Id { get; set; }
        public DateTime Date { get; set; }
        public int Mcq_Num { get; set; }
        public int TF_Num { get; set; }
    }

}
