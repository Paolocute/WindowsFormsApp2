using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{ 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            ArrayList monthList = new ArrayList();
            monthList.Add(" January ");
            monthList.Add(" February ");
            monthList.Add("March");
            monthList.Add("April");
            monthList.Add("May");
            monthList.Add("June");
            monthList.Add("July");
            monthList.Add("August");
            monthList.Add("September");
            monthList.Add("October");
            monthList.Add("November");
            monthList.Add("December");

            foreach (string month in monthList)
            {
                comboBox2.Items.Add(month.ToString());
            }
            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());

            }

            ArrayList programList = new ArrayList();

            programList.Add("Bachelor of Science in Information Technology");
            programList.Add("Bachelor of Science in Computer Science");
            programList.Add("Bachelor of Science in Information Systems");
            programList.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in programList)
            {
                comboBox4.Items.Add(program.ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox1.GetItemText(comboBox1.SelectedItem);
            string DD = comboBox2.GetItemText(comboBox2.SelectedItem);
            string YYYY = comboBox3.GetItemText(comboBox3.SelectedItem);
            string gender = radioButton1.Checked == true ? "Male" : "Female";
            string program = comboBox4.GetItemText(comboBox4.SelectedItem);
            string LastName, FirstName, MiddleName;
            LastName = T1.Text;
            FirstName = T2.Text;
            MiddleName = T3.Text;


            MessageBox.Show("Student Name: " + FirstName + " " + MiddleName + " " + LastName + "\nGender: " + gender + "\nDate of birth: " + DD + "/" + month + "/" + YYYY + "\nProgram: " + program);
        }
    }
}

