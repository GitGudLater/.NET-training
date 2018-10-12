using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_3
{
    class Man
    {
        public string _name;
        public DateTime _date;
        public string _gender;
        public int _mass;

        public Man()
        {
            _name = "John Wick";
            _date = DateTime.Now;
            _gender = "male";
            _mass = 86;
        }

        public string ChangeName(string newname)
        {
            return _name = newname;
        }

        public DateTime ChangeDate(DateTime newDate)
        {
            return _date = newDate;
        }

        public string ChangeGender(string newGender)
        {
            return _gender = newGender;
        }

        public int LoseWeight(int newMass)
        {
            return _mass = newMass;
        }
    }
}
