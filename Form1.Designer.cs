namespace TodoList
{
    partial class Form1
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
            lblTaskTitle = new Label();
            lblLocation = new Label();
            lblDate = new Label();
            lblTag = new Label();
            txtTaskTitle = new TextBox();
            txtLocation = new TextBox();
            dtpTaskDate = new DateTimePicker();
            chkImportant = new CheckBox();
            btnAddTask = new Button();
            lblTaskList = new Label();
            lblTaskDetails = new Label();
            listBox1 = new ListBox();
            splTasks = new SplitContainer();
            btnFinishTask = new Button();
            grpNewTask = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splTasks).BeginInit();
            splTasks.Panel1.SuspendLayout();
            splTasks.SuspendLayout();
            grpNewTask.SuspendLayout();
            SuspendLayout();
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.AutoSize = true;
            lblTaskTitle.Location = new Point(13, 26);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(53, 15);
            lblTaskTitle.TabIndex = 0;
            lblTaskTitle.Text = "Task title";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(13, 77);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(13, 129);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(13, 180);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(26, 15);
            lblTag.TabIndex = 3;
            lblTag.Text = "Tag";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(13, 44);
            txtTaskTitle.Margin = new Padding(3, 3, 3, 10);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(261, 23);
            txtTaskTitle.TabIndex = 4;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(13, 96);
            txtLocation.Margin = new Padding(3, 3, 3, 10);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(261, 23);
            txtLocation.TabIndex = 5;
            // 
            // dtpTaskDate
            // 
            dtpTaskDate.Location = new Point(13, 147);
            dtpTaskDate.Margin = new Padding(3, 3, 3, 10);
            dtpTaskDate.Name = "dtpTaskDate";
            dtpTaskDate.Size = new Size(261, 23);
            dtpTaskDate.TabIndex = 6;
            // 
            // chkImportant
            // 
            chkImportant.AutoSize = true;
            chkImportant.Location = new Point(13, 198);
            chkImportant.Margin = new Padding(3, 3, 3, 10);
            chkImportant.Name = "chkImportant";
            chkImportant.Size = new Size(79, 19);
            chkImportant.TabIndex = 7;
            chkImportant.Text = "Important";
            chkImportant.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(13, 241);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(261, 27);
            btnAddTask.TabIndex = 8;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            // 
            // lblTaskList
            // 
            lblTaskList.AutoSize = true;
            lblTaskList.Location = new Point(344, 18);
            lblTaskList.Name = "lblTaskList";
            lblTaskList.Size = new Size(35, 15);
            lblTaskList.TabIndex = 11;
            lblTaskList.Text = "Tasks";
            // 
            // lblTaskDetails
            // 
            lblTaskDetails.AutoSize = true;
            lblTaskDetails.Location = new Point(484, 18);
            lblTaskDetails.Name = "lblTaskDetails";
            lblTaskDetails.Size = new Size(67, 15);
            lblTaskDetails.TabIndex = 12;
            lblTaskDetails.Text = "Task details";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 360);
            listBox1.TabIndex = 13;
            // 
            // splTasks
            // 
            splTasks.Location = new Point(344, 36);
            splTasks.Margin = new Padding(3, 3, 3, 10);
            splTasks.Name = "splTasks";
            // 
            // splTasks.Panel1
            // 
            splTasks.Panel1.Controls.Add(listBox1);
            splTasks.Size = new Size(435, 360);
            splTasks.SplitterDistance = 145;
            splTasks.TabIndex = 15;
            // 
            // btnFinishTask
            // 
            btnFinishTask.Location = new Point(684, 406);
            btnFinishTask.Margin = new Padding(0, 0, 0, 0);
            btnFinishTask.Name = "btnFinishTask";
            btnFinishTask.Size = new Size(95, 23);
            btnFinishTask.TabIndex = 16;
            btnFinishTask.Text = "Mark as done";
            btnFinishTask.UseVisualStyleBackColor = true;
            // 
            // grpNewTask
            // 
            grpNewTask.Controls.Add(lblTaskTitle);
            grpNewTask.Controls.Add(txtTaskTitle);
            grpNewTask.Controls.Add(chkImportant);
            grpNewTask.Controls.Add(lblTag);
            grpNewTask.Controls.Add(lblLocation);
            grpNewTask.Controls.Add(txtLocation);
            grpNewTask.Controls.Add(lblDate);
            grpNewTask.Controls.Add(btnAddTask);
            grpNewTask.Controls.Add(dtpTaskDate);
            grpNewTask.Location = new Point(18, 18);
            grpNewTask.Margin = new Padding(0);
            grpNewTask.Name = "grpNewTask";
            grpNewTask.Padding = new Padding(10);
            grpNewTask.Size = new Size(287, 281);
            grpNewTask.TabIndex = 17;
            grpNewTask.TabStop = false;
            grpNewTask.Text = "Add task";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpNewTask);
            Controls.Add(btnFinishTask);
            Controls.Add(lblTaskDetails);
            Controls.Add(lblTaskList);
            Controls.Add(splTasks);
            Name = "Form1";
            Padding = new Padding(18);
            Text = "Form1";
            splTasks.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splTasks).EndInit();
            splTasks.ResumeLayout(false);
            grpNewTask.ResumeLayout(false);
            grpNewTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewTask;
        private Label lblTaskTitle;
        private Label lblLocation;
        private Label lblDate;
        private Label lblTag;
        private TextBox txtTaskTitle;
        private TextBox txtNewTask;
        private TextBox txtLocation;
        private DateTimePicker dtpTaskDate;
        private CheckBox chkImportant;
        private Button btnAddTask;
        private Label lblTaskList;
        private Label lblTaskDetails;
        private ListBox listBox1;
        private SplitContainer splTasks;
        private Button btnFinishTask;
        private GroupBox grpNewTask;
    }
}
