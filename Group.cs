using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3
{
    class Group:Student
    {
        public Student[] _groupOfStudents;
        public string[] _subjects;
        protected Journal _journal;
        public Group(Journal journal,Student[] group)
        {
            _journal = journal;
            _groupOfStudents = group;
        }
        public void ChageJournal(bool missed, Student[] student)
        {
            _journal = new Journal(missed, student);
        }
    }
}
