using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RPS
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("SWE4201MarkSheet.txt");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] col = new string[10];
                col = line.Split(',');
                Student dummy = new Student(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7], col[8], col[9]);
                students.Add(dummy);
            }

            for (int i = 1; i < students.Count; i++)
            {
                listBoxStudents.Items.Add(students[i].name + "\t" + students[i].id);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            var stdnt = from studentss in students
                        where studentss.id == id
                        select studentss;

            foreach(var s in stdnt)
            {
                textBox6.Text = s.attendence;
                textBox2.Text = s.quiz[0];
                textBox3.Text = s.quiz[1];
                textBox4.Text = s.quiz[2];
                textBox5.Text = s.quiz[3];
                textBox7.Text = s.CalculateQuizMark().ToString();
                textBox8.Text = s.mid;
                textBox9.Text = s.final;
                textBox10.Text = s.viva;
                textBox11.Text = s.CalculateTotal().ToString();
                textBox12.Text = s.CalculatePercentage().ToString();
                textBox13.Text = s.CalculateGrade();
            }
        }
    }
}
