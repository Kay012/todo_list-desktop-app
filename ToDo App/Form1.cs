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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string f = File.ReadAllText("C:\\ToDoApp\\data.txt");

            //this.Hide();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //public string TaskNum()
        //{
        //    string[] fil = File.ReadAllLines("C:\\ToDoApp\\data.txt");
        //    return (fil.Length + 1.ToString());
        //}
        private void Button1_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtbox3.Text = "";
            txtbox4.Text = "";
            txtTitle.Focus();

            

        }

        private void BtnViewAllTask_Click(object sender, EventArgs e)
        {


            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();

        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
            
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();

            //txtbox1.Text = "";
            //txtbox2.Text = "";
            //txtbox3.Text = "";
            //txtbox4.Text = "";
            //txtTitle.Focus();

            //string content = txtbox1.Text + ",";
            //content += txtbox2.Text + ",";
            //content += txtbox3.Text + ",";
            //content += txtbox4.Text + System.Environment.NewLine;

            //File.WriteAllText("C:\\ToDoApp\\data.txt", content);

            //Button1_Click(sender, e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //validating texboxes
            if (txtbox1.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Title");
                txtbox1.Focus();
                return;
            }
            if (txtbox2.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Description");
                txtbox2.Focus();
                return;
            }
            if (txtbox3.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to a pick a date");
                txtbox3.Focus();
                return;
            }
            if (txtbox4.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Time");
                txtbox4.Focus();
                return;
            }
            //SAVING FIELDS TO FILE
            //TaskNum t = new TaskNum();
            
            string content = txtbox1.Text + "|";
            content += txtbox2.Text + "|";
            content += txtbox3.Text + "|";
            content += txtbox4.Text + System.Environment.NewLine;

            File.AppendAllText("C:\\ToDoApp\\"+ txtbox1.Text + ".txt",  content);
            MessageBox.Show("Task Saved!");
            Button1_Click(sender, e);


        }

        private void Txtbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbox3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtTitle_Click(object sender, EventArgs e)
        {

        }
    }

}
