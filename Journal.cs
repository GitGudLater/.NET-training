using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3
{
    class Journal
    {
        protected bool _missed;
        protected Student [] _student;
        public Journal(bool missed,Student [] student)
        {
            _missed = missed;
            _student = student;
        }
    }
}
