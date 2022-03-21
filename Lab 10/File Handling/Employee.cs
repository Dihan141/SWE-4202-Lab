using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Employee
    {
        public string id, firstName, lastName, email, phoneNum, hireDate, jobId, salary, comission, managerId, depId;

        public Employee(string id,string firstName, string lastName, string email, string phoneNum, string hireDate, string jobId, string salary, string comission, string managerId, string depId)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNum = phoneNum;
            this.hireDate = hireDate;
            this.jobId = jobId;
            this.salary = salary;
            this.comission = comission;
            this.managerId = managerId;
            this.depId = depId;
        }

        public string getName()
        {
            return firstName;
        }
        public string getId()
        {
            return id;
        }
    }
}
