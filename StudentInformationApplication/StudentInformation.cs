using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationApplication
{
    public class StudentInfo
    {

        
        private string studentID;
        private string firstName;
        private string lastName;

       
        public StudentInfo()
        {
            this.StudentID = "";
            this.firstName = "";
            this.lastName = "";
        }

      
        public StudentInfo(string studentID, string firstName, string lastName)
        {
            this.StudentID = studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

     
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}