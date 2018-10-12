using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3
{
    class Student:Man
    {
        public Man _student;
        public int _studyYear;
        public Student()
        {
            _student = new Student();
            _studyYear = 1;
        }

        public int ChangeStudyYear(int newStudyYear)
        {
            return _studyYear = newStudyYear;
        }

        public int UpgradeStudyYear(int upgradeStudyYear)
        {
            return _studyYear += upgradeStudyYear;
        }
    }
}
