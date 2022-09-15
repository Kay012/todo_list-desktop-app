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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string[] filepaths = Directory.GetFiles(@"C:\\ToDoApp\", "*.txt");
            foreach (string file in filepaths)
            {
                
                string line = File.ReadAllText(file);
                string wo = "";
                string strl = "";
                foreach (char word in line)
                {
                    wo += word;
                }
                strl += wo;
                List_Of_Tasks.Items.Add(strl); ;
                
            }
        }

        public void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

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

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void All_Tasks_Click(object sender, EventArgs e)
        {
            string[] filepaths = Directory.GetFiles(@"C:\\ToDoApp\", "*.txt");
            foreach (string file in filepaths)
            {
                
                
                List_Of_Tasks.Items.Add(Path.GetFileName(file));
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string[] filepaths = Directory.GetFiles(@"C:\\ToDoApp\", "*,txt");
            //foreach (string file in filepaths)
            //{
            //    comboBox1.Items.Add(Path.GetFileName(file));
            //}
        }

        private void TxtEnter_Click(object sender, EventArgs e)
        {
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\ToDoApp\\" + searcher.Text + ".txtx");
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Title");
                return;
            }
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Description");
                return;
            }
            if (txtDate.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to a pick a date");
                return;
            }
            if (txtTime.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Time");
                return;
            }
            //SAVING FIELDS TO FILE
            //TaskNum t = new TaskNum();

            string content = txtbox1.Text + "|";
            content += txtbox2.Text + "|";
            content += txtbox3.Text + "|";
            content += txtbox4.Text + System.Environment.NewLine;

            File.AppendAllText("C:\\ToDoApp\\" + txtbox1.Text + ".txt", content);
            MessageBox.Show("Task Updated!");
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }
    }
}
