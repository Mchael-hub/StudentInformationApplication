using System;
using System.Windows.Forms;

namespace StudentInformationApplication
{
    public partial class FormStudentInformation : Form
    {
        public FormStudentInformation()
        {

            InitializeComponent();
        }

}

        private void button6_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(
           txtID.Text,
           txtFirstName.Text,
           txtLastName.Text

           );

            listBox1.Items.Add(student.StudentID);
            listBox2.Items.Add(student.FirstName);
            listBox3.Items.Add(student.LastName);
        }
    }
  }


