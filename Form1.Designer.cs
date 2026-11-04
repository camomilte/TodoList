namespace TodoList
{
    partial class formTaskManager
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
            lblDueDate = new Label();
            lblTag = new Label();
            txtTaskTitle = new TextBox();
            txtLocation = new TextBox();
            dtpTaskDueDate = new DateTimePicker();
            chkImportant = new CheckBox();
            btnAddTask = new Button();
            btnFinishTask = new Button();
            lstTasksActive = new ListBox();
            splTasks = new SplitContainer();
            rtxTaskDetailsActive = new RichTextBox();
            grpNewTask = new GroupBox();
            tabTaskList = new TabControl();
            tabPageActive = new TabPage();
            tabPageFinished = new TabPage();
            splitContainer1 = new SplitContainer();
            lstTasksFinished = new ListBox();
            rtxTaskDetailsFinished = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splTasks).BeginInit();
            splTasks.Panel1.SuspendLayout();
            splTasks.Panel2.SuspendLayout();
            splTasks.SuspendLayout();
            grpNewTask.SuspendLayout();
            tabTaskList.SuspendLayout();
            tabPageActive.SuspendLayout();
            tabPageFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(13, 129);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(54, 15);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due date";
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
            // dtpTaskDueDate
            // 
            dtpTaskDueDate.Location = new Point(13, 147);
            dtpTaskDueDate.Margin = new Padding(3, 3, 3, 10);
            dtpTaskDueDate.Name = "dtpTaskDueDate";
            dtpTaskDueDate.Size = new Size(261, 23);
            dtpTaskDueDate.TabIndex = 6;
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
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnFinishTask
            // 
            btnFinishTask.Location = new Point(344, 357);
            btnFinishTask.Margin = new Padding(0);
            btnFinishTask.Name = "btnFinishTask";
            btnFinishTask.Size = new Size(95, 23);
            btnFinishTask.TabIndex = 16;
            btnFinishTask.Text = "Mark as done";
            btnFinishTask.UseVisualStyleBackColor = true;
            btnFinishTask.Click += btnFinishTask_Click;
            // 
            // lstTasksActive
            // 
            lstTasksActive.Dock = DockStyle.Fill;
            lstTasksActive.FormattingEnabled = true;
            lstTasksActive.Location = new Point(0, 0);
            lstTasksActive.Name = "lstTasksActive";
            lstTasksActive.Size = new Size(162, 344);
            lstTasksActive.TabIndex = 13;
            lstTasksActive.SelectedIndexChanged += lstTasksActive_SelectedIndexChanged;
            // 
            // splTasks
            // 
            splTasks.Dock = DockStyle.Top;
            splTasks.Location = new Point(3, 3);
            splTasks.Margin = new Padding(3, 3, 3, 10);
            splTasks.Name = "splTasks";
            // 
            // splTasks.Panel1
            // 
            splTasks.Panel1.Controls.Add(lstTasksActive);
            // 
            // splTasks.Panel2
            // 
            splTasks.Panel2.Controls.Add(rtxTaskDetailsActive);
            splTasks.Size = new Size(436, 344);
            splTasks.SplitterDistance = 162;
            splTasks.TabIndex = 15;
            // 
            // rtxTaskDetailsActive
            // 
            rtxTaskDetailsActive.Dock = DockStyle.Fill;
            rtxTaskDetailsActive.Location = new Point(0, 0);
            rtxTaskDetailsActive.Name = "rtxTaskDetailsActive";
            rtxTaskDetailsActive.ReadOnly = true;
            rtxTaskDetailsActive.Size = new Size(270, 344);
            rtxTaskDetailsActive.TabIndex = 18;
            rtxTaskDetailsActive.Text = "";
            // 
            // grpNewTask
            // 
            grpNewTask.Controls.Add(lblTaskTitle);
            grpNewTask.Controls.Add(txtTaskTitle);
            grpNewTask.Controls.Add(chkImportant);
            grpNewTask.Controls.Add(lblTag);
            grpNewTask.Controls.Add(lblLocation);
            grpNewTask.Controls.Add(txtLocation);
            grpNewTask.Controls.Add(lblDueDate);
            grpNewTask.Controls.Add(btnAddTask);
            grpNewTask.Controls.Add(dtpTaskDueDate);
            grpNewTask.Location = new Point(18, 18);
            grpNewTask.Margin = new Padding(0);
            grpNewTask.Name = "grpNewTask";
            grpNewTask.Padding = new Padding(10);
            grpNewTask.Size = new Size(287, 281);
            grpNewTask.TabIndex = 17;
            grpNewTask.TabStop = false;
            grpNewTask.Text = "Add task";
            // 
            // tabTaskList
            // 
            tabTaskList.Controls.Add(tabPageActive);
            tabTaskList.Controls.Add(tabPageFinished);
            tabTaskList.Location = new Point(329, 18);
            tabTaskList.Name = "tabTaskList";
            tabTaskList.SelectedIndex = 0;
            tabTaskList.Size = new Size(450, 411);
            tabTaskList.TabIndex = 14;
            // 
            // tabPageActive
            // 
            tabPageActive.Controls.Add(splTasks);
            tabPageActive.Controls.Add(btnFinishTask);
            tabPageActive.Location = new Point(4, 24);
            tabPageActive.Name = "tabPageActive";
            tabPageActive.Padding = new Padding(3);
            tabPageActive.Size = new Size(442, 383);
            tabPageActive.TabIndex = 0;
            tabPageActive.Text = "Active";
            tabPageActive.UseVisualStyleBackColor = true;
            // 
            // tabPageFinished
            // 
            tabPageFinished.Controls.Add(splitContainer1);
            tabPageFinished.Location = new Point(4, 24);
            tabPageFinished.Name = "tabPageFinished";
            tabPageFinished.Padding = new Padding(3);
            tabPageFinished.Size = new Size(442, 383);
            tabPageFinished.TabIndex = 1;
            tabPageFinished.Text = "Finished";
            tabPageFinished.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstTasksFinished);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(rtxTaskDetailsFinished);
            splitContainer1.Size = new Size(436, 377);
            splitContainer1.SplitterDistance = 164;
            splitContainer1.TabIndex = 0;
            // 
            // lstTasksFinished
            // 
            lstTasksFinished.Dock = DockStyle.Fill;
            lstTasksFinished.FormattingEnabled = true;
            lstTasksFinished.Location = new Point(0, 0);
            lstTasksFinished.Name = "lstTasksFinished";
            lstTasksFinished.Size = new Size(164, 377);
            lstTasksFinished.TabIndex = 0;
            // 
            // rtxTaskDetailsFinished
            // 
            rtxTaskDetailsFinished.Dock = DockStyle.Fill;
            rtxTaskDetailsFinished.Location = new Point(0, 0);
            rtxTaskDetailsFinished.Name = "rtxTaskDetailsFinished";
            rtxTaskDetailsFinished.ReadOnly = true;
            rtxTaskDetailsFinished.Size = new Size(268, 377);
            rtxTaskDetailsFinished.TabIndex = 0;
            rtxTaskDetailsFinished.Text = "";
            // 
            // formTaskManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabTaskList);
            Controls.Add(grpNewTask);
            Name = "formTaskManager";
            Padding = new Padding(18);
            Text = "Task Manager";
            splTasks.Panel1.ResumeLayout(false);
            splTasks.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splTasks).EndInit();
            splTasks.ResumeLayout(false);
            grpNewTask.ResumeLayout(false);
            grpNewTask.PerformLayout();
            tabTaskList.ResumeLayout(false);
            tabPageActive.ResumeLayout(false);
            tabPageFinished.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNewTask;
        private Label lblTaskTitle;
        private Label lblLocation;
        private Label lblDueDate;
        private Label lblTag;
        private TextBox txtTaskTitle;
        private TextBox txtLocation;
        private DateTimePicker dtpTaskDueDate;
        private CheckBox chkImportant;
        private Button btnAddTask;
        private ListBox lstTasksActive;
        private SplitContainer splTasks;
        private Button btnFinishTask;
        private GroupBox grpNewTask;
        private RichTextBox rtxTaskDetailsActive;
        private TabControl tabTaskList;
        private TabPage tabPageActive;
        private TabPage tabPageFinished;
        private SplitContainer splitContainer1;
        private ListBox lstTasksFinished;
        private RichTextBox rtxTaskDetailsFinished;
    }
}
