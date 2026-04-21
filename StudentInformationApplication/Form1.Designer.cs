using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace StudentInformationApplication
{
    partial class FormStudentInformation : Form 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.label2.Location = new System.Drawing.Point(275, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.label3.Location = new System.Drawing.Point(510, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAST NAME";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(35, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(279, 51);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(514, 52);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(190)))));
            this.button1.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(686, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 264);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(279, 132);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(173, 264);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(514, 129);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(173, 264);
            this.listBox3.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(190)))));
            this.button6.Font = new System.Drawing.Font("MS PGothic", 12F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(686, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 30);
            this.button6.TabIndex = 11;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // FormStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(793, 485);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStudentInformation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button6;
    }
}