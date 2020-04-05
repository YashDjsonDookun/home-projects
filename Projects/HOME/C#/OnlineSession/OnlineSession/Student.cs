using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSession
{
    class Student
    {
        private string _name;
        private int _sid;
        private double _midterm;
        private double _final;

        public Student()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public int Sid { get => _sid; set => _sid = value; }
        public double Midterm { get => _midterm; set => _midterm = value; }
        public double Final { get => _final; set => _final = value; }


        public string CalcSemGrade()
        {
            double grade = (_midterm + _final) / 2;
            string result;
            switch (grade)
            {
                case double m when (m >= 70):
                    result = "A";
                    break;
                case double m when (m >=60):
                    result = "B";
                    break;
                case double m when (m >= 50):
                    result = "C";
                    break;
                case double m when (m >= 40):
                    result = "D";
                    break;
                default:
                    result = "F";
                    break;
            }
            return result;
        }
    }
}
