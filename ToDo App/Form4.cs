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

namespace ToDo_App
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //string[] filepaths = Directory.GetFiles(@"C:\\ToDoApp\", "*.txt");
            //foreach (string file in filepaths)
            //{
            //    List_Of_Task_Titles.Items.Add(Path.GetFileName(file));
            //}
        }
        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\ToDoApp\\" + searcher.Text + ".txt");
            MessageBox.Show("Task Deleted!");
            List_Of_Tasks.Items.Clear();
            All_tasks_Click(sender, e);
            
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void BtnViewAllTask_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void TxtEnter_Click(object sender, EventArgs e)
        {
            List_Of_Tasks.Items.Clear();
            string[] f = File.ReadAllLines("C:\\ToDoApp\\" + searcher.Text + ".txt");
            for (int i = 0; i < f.Length; i++)
            {
                string[] access = f[i].Split('|');
                txtbox1.Text = access[0];
                txtbox2.Text = access[1];
                txtbox3.Text = access[2];
                txtbox4.Text = access[3];
            }
        }

        public void All_tasks_Click(object sender, EventArgs e)
        {
            List_Of_Tasks.Items.Clear();

            string[] filepaths = Directory.GetFiles(@"C:\\ToDoApp\", "*.txt");
            foreach (string file in filepaths)
            {
                
                string line = File.ReadAllText(file);
                string task = "";
                string tasks = "";
                foreach (char word in line)
                {
                    task += word;
                }
                tasks += task;
                List_Of_Tasks.Items.Add(tasks);
            }
        }

        public void List_Of_Task_Titles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
