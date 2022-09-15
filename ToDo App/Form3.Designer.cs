namespace ToDo_App
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox3 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtbox4 = new System.Windows.Forms.TextBox();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnViewAllTask = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searcher = new System.Windows.Forms.TextBox();
            this.txtEnter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.List_Of_Tasks = new System.Windows.Forms.ListBox();
            this.all_tasks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtbox2);
            this.groupBox1.Controls.Add(this.txtbox4);
            this.groupBox1.Controls.Add(this.txtbox1);
            this.groupBox1.Location = new System.Drawing.Point(789, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 366);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Panel";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(198, 174);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(274, 22);
            this.txtbox3.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(379, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(66, 233);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(97, 25);
            this.txtTime.TabIndex = 11;
            this.txtTime.Text = "Due Time";
            this.txtTime.Click += new System.EventHandler(this.TxtTime_Click);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(67, 171);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(94, 25);
            this.txtDate.TabIndex = 10;
            this.txtDate.Text = "Due Date";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(66, 106);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(109, 25);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Text = "Description";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(66, 53);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(49, 25);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Text = "Title";
            this.txtTitle.Click += new System.EventHandler(this.TxtTitle_Click);
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(198, 106);
            this.txtbox2.Multiline = true;
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(274, 51);
            this.txtbox2.TabIndex = 7;
            // 
            // txtbox4
            // 
            this.txtbox4.Location = new System.Drawing.Point(198, 233);
            this.txtbox4.Name = "txtbox4";
            this.txtbox4.Size = new System.Drawing.Size(274, 22);
            this.txtbox4.TabIndex = 6;
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(198, 57);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(274, 22);
            this.txtbox1.TabIndex = 4;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Location = new System.Drawing.Point(942, 172);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(132, 55);
            this.btnDeleteTask.TabIndex = 8;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask_Click);
            // 
            // btnViewAllTask
            // 
            this.btnViewAllTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllTask.Location = new System.Drawing.Point(1131, 172);
            this.btnViewAllTask.Name = "btnViewAllTask";
            this.btnViewAllTask.Size = new System.Drawing.Size(130, 55);
            this.btnViewAllTask.TabIndex = 7;
            this.btnViewAllTask.Text = "View All Tasks";
            this.btnViewAllTask.UseVisualStyleBackColor = true;
            this.btnViewAllTask.Click += new System.EventHandler(this.BtnViewAllTask_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(789, 172);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 55);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add New Task";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Title to Edit";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // searcher
            // 
            this.searcher.Location = new System.Drawing.Point(744, 310);
            this.searcher.Name = "searcher";
            this.searcher.Size = new System.Drawing.Size(273, 22);
            this.searcher.TabIndex = 13;
            this.searcher.TextChanged += new System.EventHandler(this.Searcher_TextChanged);
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(928, 338);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(89, 40);
            this.txtEnter.TabIndex = 14;
            this.txtEnter.Text = "Enter";
            this.txtEnter.UseVisualStyleBackColor = true;
            this.txtEnter.Click += new System.EventHandler(this.TxtEnter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // List_Of_Tasks
            // 
            this.List_Of_Tasks.FormattingEnabled = true;
            this.List_Of_Tasks.ItemHeight = 16;
            this.List_Of_Tasks.Location = new System.Drawing.Point(12, 387);
            this.List_Of_Tasks.Name = "List_Of_Tasks";
            this.List_Of_Tasks.Size = new System.Drawing.Size(551, 452);
            this.List_Of_Tasks.TabIndex = 15;
            this.List_Of_Tasks.SelectedIndexChanged += new System.EventHandler(this.List_Of_Task_Titles_SelectedIndexChanged);
            // 
            // all_tasks
            // 
            this.all_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_tasks.Location = new System.Drawing.Point(12, 310);
            this.all_tasks.Name = "all_tasks";
            this.all_tasks.Size = new System.Drawing.Size(551, 60);
            this.all_tasks.TabIndex = 25;
            this.all_tasks.Text = "Click Here To Upload All Tasks";
            this.all_tasks.UseVisualStyleBackColor = true;
            this.all_tasks.Click += new System.EventHandler(this.All_tasks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 52);
            this.label2.TabIndex = 27;
            this.label2.Text = "To Do List App";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 44);
            this.label3.TabIndex = 26;
            this.label3.Text = "Edit Tasks";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 851);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.all_tasks);
            this.Controls.Add(this.List_Of_Tasks);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.searcher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnViewAllTask);
            this.Controls.Add(this.btnAddNew);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtbox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox4;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnViewAllTask;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searcher;
        private System.Windows.Forms.Button txtEnter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox List_Of_Tasks;
        private System.Windows.Forms.Button all_tasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}