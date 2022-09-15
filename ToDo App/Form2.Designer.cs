namespace ToDo_App
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.List_Of_Tasks = new System.Windows.Forms.ListBox();
            this.txtEnter = new System.Windows.Forms.Button();
            this.searcher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox3 = new System.Windows.Forms.DateTimePicker();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtbox4 = new System.Windows.Forms.TextBox();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Tasks";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "To Do List App";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.Location = new System.Drawing.Point(633, 92);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(124, 55);
            this.btnEditTask.TabIndex = 10;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Location = new System.Drawing.Point(796, 92);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(132, 55);
            this.btnDeleteTask.TabIndex = 9;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(487, 92);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 55);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Add New Task";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // List_Of_Tasks
            // 
            this.List_Of_Tasks.FormattingEnabled = true;
            this.List_Of_Tasks.ItemHeight = 16;
            this.List_Of_Tasks.Location = new System.Drawing.Point(12, 264);
            this.List_Of_Tasks.Name = "List_Of_Tasks";
            this.List_Of_Tasks.Size = new System.Drawing.Size(372, 340);
            this.List_Of_Tasks.TabIndex = 12;
            this.List_Of_Tasks.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged_1);
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(717, 264);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(89, 40);
            this.txtEnter.TabIndex = 18;
            this.txtEnter.Text = "Enter";
            this.txtEnter.UseVisualStyleBackColor = true;
            this.txtEnter.Click += new System.EventHandler(this.TxtEnter_Click);
            // 
            // searcher
            // 
            this.searcher.Location = new System.Drawing.Point(475, 236);
            this.searcher.Name = "searcher";
            this.searcher.Size = new System.Drawing.Size(273, 22);
            this.searcher.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Title to View Full Task";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox3);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtbox2);
            this.groupBox1.Controls.Add(this.txtbox4);
            this.groupBox1.Controls.Add(this.txtbox1);
            this.groupBox1.Location = new System.Drawing.Point(519, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 366);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Panel";
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(198, 174);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(274, 22);
            this.txtbox3.TabIndex = 12;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 705);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.searcher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.List_Of_Tasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ListBox List_Of_Tasks;
        private System.Windows.Forms.Button txtEnter;
        private System.Windows.Forms.TextBox searcher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtbox3;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox4;
        private System.Windows.Forms.TextBox txtbox1;
    }
}