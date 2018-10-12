using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3
{
    class Teacher:Student
    {
        public Group _group;
        public Man _teacher;
        public DateTime _workHours;
        public Teacher(Group group,DateTime workHours)
        {
            _group = group;
            _workHours = workHours;
        }
        public void SetSubject(int numOfSubject, string nameOfSubject)
        {
            _group._subjects[numOfSubject] = nameOfSubject;
        }


    }
}
