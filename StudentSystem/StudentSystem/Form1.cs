using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static StudentSystem.Student;

namespace StudentSystem
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                Id = int.Parse(textBox2.Text),
                Name = textBox1.Text,
                Age = int.Parse(textBox3.Text)
            };

            students.Add(s);

            RefreshGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);

            students.RemoveAll(s => s.Id == id);

            RefreshGrid();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox2.Text);

            var result = students.Where(s => s.Id == id).ToList();

            dataGridView1.DataSource = result;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
