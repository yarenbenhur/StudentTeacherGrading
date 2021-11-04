using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwlab2
{
    public class ClassNotes
    {
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public Grade Grade { get; set; }
        public ClassNotes(int teacherId, int studentId, Grade grade)
        {
            TeacherId = teacherId;
            StudentId = studentId;
            Grade = grade;

        }




    }
}
