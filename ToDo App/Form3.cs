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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 5)
            //{
            //    string[] f = File.ReadAllLines("C:\\ToDoApp\\data.txt");
            //    string colum = f[e.RowIndex];
            //    string[] col = colum.Split('-');

            //    txtbox1.Text = col[1];
            //    txtbox2.Text = col[2];
            //    txtbox3.Text = col[3];
            //    txtbox4.Text = col[4];

            //    num = e.RowIndex;

            //}

        }

        //private void Upload_Click(object sender, EventArgs e)
        //{
        //    string[] f = File.ReadAllLines("C:\\ToDoApp\\data.txt");
        //    for (int i = 0; i < f.Length; i++)
        //    {
        //        string[] colum = f[i].Split('-');
        //        gridView.Rows.Add(colum[0], colum[1], colum[2], colum[3], colum[4]);
        //    }

        //}

        private void TxtTitle_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\ToDoApp\\" + searcher.Text + ".txt");
            if (txtbox1.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Title");
                return;
            }
            if (txtbox2.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Description");
                return;
            }
            if (txtbox3.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to a pick a date");
                return;
            }
            if (txtbox4.Text.Trim() == "")
            {
                MessageBox.Show("ERROR! You need to enter a Time");
                return;
            }
            

            string content = txtbox1.Text + "|";
            content += txtbox2.Text + "|";
            content += txtbox3.Text + "|";
            content += txtbox4.Text + System.Environment.NewLine;

            File.AppendAllText("C:\\ToDoApp\\" + txtbox1.Text +".txt", content);
            MessageBox.Show("Task Updated!");
            List_Of_Tasks.Items.Clear();
            All_tasks_Click(sender, e);

            

        }

        private void TxtTime_Click(object sender, EventArgs e)
        {

        }

        private void BtnViewAllTask_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void TxtEnter_Click(object sender, EventArgs e)
        {
            string[] f = File.ReadAllLines("C:\\ToDoApp\\" + searcher.Text + ".txt");
            for (int i = 0; i< f.Length; i++)
            {
                string[] access = f[i].Split('|');
                txtbox1.Text = access[0];
                txtbox2.Text = access[1];
                txtbox3.Text = access[2];
                txtbox4.Text = access[3];
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Searcher_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void List_Of_Task_Titles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void All_tasks_Click(object sender, EventArgs e)
        {
            List_Of_Tasks.Items.Clear();

            string[] filepaths = Directory.GetFiles(@"C:\\ToDoApp\", "*.txt");
            foreach (string file in filepaths)
            {
                //List_Of_Task_Titles.Items.Add(Path.GetFileName(file));
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
    }
}
