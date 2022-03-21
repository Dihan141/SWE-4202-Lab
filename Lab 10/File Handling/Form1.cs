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

namespace File_Handling
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("employees.csv");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] col = new string[11];
                col = line.Split(',');
                Employee dummy = new Employee(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7], col[8], col[9], col[10]);
                employees.Add(dummy);
            }

            for(int i=1; i<employees.Count;i++)
            {
                listBox1.Items.Add(employees[i].getId() + "\t" + employees[i].getName());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBoxSearch.Text;
            int flag = 0;
            DateTime time = DateTime.Now;
            
            foreach(Employee em in employees)
            {
                if(em.getId() == id)
                {
                    textBoxFname.Text = em.firstName;
                    textBoxLname.Text = em.lastName;
                    textBoxEmail.Text = em.email;
                    textBoxNum.Text = em.phoneNum;
                    textBoxHireDate.Text = em.hireDate;
                    textBoxJobId.Text = em.jobId;
                    textBoxSalary.Text = em.salary;
                    textBoxComission.Text = em.comission;
                    textBoxManId.Text = em.managerId;
                    textBoxDepId.Text = em.depId;
                    flag = 1;
                }
            }

            StreamWriter wr = File.AppendText("log.txt");
            if(flag == 0)
            {
                wr.WriteLine("no id" + "\t" + id + "\t" + time);
                MessageBox.Show("Invalid ID");
                wr.Close();
            }
            else
            {
                wr.WriteLine("id verified" + "\t" + id + "\t" + time);
                wr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
