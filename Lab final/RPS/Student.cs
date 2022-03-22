using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    internal class Student
    {
        public string id, name;
        public string attendence, mid, final, viva;
        public string[] quiz = new string[4];
        public double percentage;
        public int total1;

        public Student(string id, string name, string attendence, string quiz1, string quiz2, string quiz3, string quiz4, string mid, string final, string viva)
        {
            this.id = id;
            this.name = name;
            this.attendence = attendence;
            quiz[0] = quiz1;
            quiz[1] = quiz2;
            quiz[2] = quiz3;
            quiz[3] = quiz4;
            this.mid = mid;
            this.final = final;
            this.viva = viva;
        }
        public int CalculateQuizMark()
        {
            Array.Sort(quiz);
            int total = int.Parse(quiz[1]) + int.Parse(quiz[2]) + int.Parse(quiz[3]);
            return total;
        }
        public int CalculateTotal()
        {
            total1 = int.Parse(mid) + int.Parse(final) + int.Parse(viva) + CalculateQuizMark();
            return total1;
        }

        public double CalculatePercentage()
        {
            percentage = (double)CalculateTotal() / 300;
            return percentage * 100;
        }
        public string CalculateGrade()
        {
            if (percentage >= 80f && percentage <= 100f)
                return "A+";
            if (percentage >= 75f && percentage <= 79f)
                return "A";
            if (percentage >= 70f && percentage <= 74f)
                return "A-";
            if (percentage >= 65f && percentage <= 69f)
                return "B+";
            if (percentage >= 60f && percentage <= 64f)
                return "B";
            if (percentage >= 55f && percentage <= 59f)
                return "B-";
            if (percentage >= 50f && percentage <= 54f)
                return "C+";
            if (percentage >= 45f && percentage <= 49f)
                return "C";
            if (percentage >= 40f && percentage <= 44f)
                return "D";
            else
                return "F";
        }
    }
}
