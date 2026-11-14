namespace TodoList
{
    partial class formTodoManager
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
            lblTodoItemTitle = new Label();
            lblTodoItemLocation = new Label();
            lblTodoItemDueDate = new Label();
            txtTodoItemTitle = new TextBox();
            txtTodoItemLocation = new TextBox();
            dtpTodoItemDueDate = new DateTimePicker();
            chkTodoItemImportant = new CheckBox();
            btnAddTodoItem = new Button();
            btnFinishTodoItem = new Button();
            lstTodoListActive = new ListBox();
            splTodosActive = new SplitContainer();
            rtxTodoItemDetailsActive = new RichTextBox();
            grpNewTodoItem = new GroupBox();
            tabTodoList = new TabControl();
            tabPageActive = new TabPage();
            tabPageFinished = new TabPage();
            btnReactivateTodoItem = new Button();
            splTodosFinished = new SplitContainer();
            lstTodoListFinished = new ListBox();
            rtxTodoItemDetailsFinished = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splTodosActive).BeginInit();
            splTodosActive.Panel1.SuspendLayout();
            splTodosActive.Panel2.SuspendLayout();
            splTodosActive.SuspendLayout();
            grpNewTodoItem.SuspendLayout();
            tabTodoList.SuspendLayout();
            tabPageActive.SuspendLayout();
            tabPageFinished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splTodosFinished).BeginInit();
            splTodosFinished.Panel1.SuspendLayout();
            splTodosFinished.Panel2.SuspendLayout();
            splTodosFinished.SuspendLayout();
            SuspendLayout();
            // 
            // lblTodoItemTitle
            // 
            lblTodoItemTitle.AutoSize = true;
            lblTodoItemTitle.Location = new Point(13, 26);
            lblTodoItemTitle.Name = "lblTodoItemTitle";
            lblTodoItemTitle.Size = new Size(53, 15);
            lblTodoItemTitle.TabIndex = 0;
            lblTodoItemTitle.Text = "Task title";
            // 
            // lblTodoItemLocation
            // 
            lblTodoItemLocation.AutoSize = true;
            lblTodoItemLocation.Location = new Point(13, 77);
            lblTodoItemLocation.Name = "lblTodoItemLocation";
            lblTodoItemLocation.Size = new Size(53, 15);
            lblTodoItemLocation.TabIndex = 1;
            lblTodoItemLocation.Text = "Location";
            // 
            // lblTodoItemDueDate
            // 
            lblTodoItemDueDate.AutoSize = true;
            lblTodoItemDueDate.Location = new Point(13, 129);
            lblTodoItemDueDate.Name = "lblTodoItemDueDate";
            lblTodoItemDueDate.Size = new Size(54, 15);
            lblTodoItemDueDate.TabIndex = 2;
            lblTodoItemDueDate.Text = "Due date";
            // 
            // txtTodoItemTitle
            // 
            txtTodoItemTitle.Location = new Point(13, 44);
            txtTodoItemTitle.Margin = new Padding(3, 3, 3, 10);
            txtTodoItemTitle.Name = "txtTodoItemTitle";
            txtTodoItemTitle.Size = new Size(261, 23);
            txtTodoItemTitle.TabIndex = 4;
            // 
            // txtTodoItemLocation
            // 
            txtTodoItemLocation.Location = new Point(13, 96);
            txtTodoItemLocation.Margin = new Padding(3, 3, 3, 10);
            txtTodoItemLocation.Name = "txtTodoItemLocation";
            txtTodoItemLocation.Size = new Size(261, 23);
            txtTodoItemLocation.TabIndex = 5;
            // 
            // dtpTodoItemDueDate
            // 
            dtpTodoItemDueDate.Location = new Point(13, 147);
            dtpTodoItemDueDate.Margin = new Padding(3, 3, 3, 10);
            dtpTodoItemDueDate.Name = "dtpTodoItemDueDate";
            dtpTodoItemDueDate.Size = new Size(261, 23);
            dtpTodoItemDueDate.TabIndex = 6;
            // 
            // chkTodoItemImportant
            // 
            chkTodoItemImportant.AutoSize = true;
            chkTodoItemImportant.Location = new Point(13, 198);
            chkTodoItemImportant.Margin = new Padding(3, 3, 3, 10);
            chkTodoItemImportant.Name = "chkTodoItemImportant";
            chkTodoItemImportant.Size = new Size(79, 19);
            chkTodoItemImportant.TabIndex = 7;
            chkTodoItemImportant.Text = "Important";
            chkTodoItemImportant.UseVisualStyleBackColor = true;
            // 
            // btnAddTodoItem
            // 
            btnAddTodoItem.Location = new Point(13, 241);
            btnAddTodoItem.Name = "btnAddTodoItem";
            btnAddTodoItem.Size = new Size(261, 27);
            btnAddTodoItem.TabIndex = 8;
            btnAddTodoItem.Text = "Add Task";
            btnAddTodoItem.UseVisualStyleBackColor = true;
            btnAddTodoItem.Click += btnAddTask_Click;
            // 
            // btnFinishTodoItem
            // 
            btnFinishTodoItem.Location = new Point(344, 357);
            btnFinishTodoItem.Margin = new Padding(0);
            btnFinishTodoItem.Name = "btnFinishTodoItem";
            btnFinishTodoItem.Size = new Size(95, 23);
            btnFinishTodoItem.TabIndex = 16;
            btnFinishTodoItem.Text = "Mark as done";
            btnFinishTodoItem.UseVisualStyleBackColor = true;
            btnFinishTodoItem.Click += btnFinishTask_Click;
            // 
            // lstTodoListActive
            // 
            lstTodoListActive.Dock = DockStyle.Fill;
            lstTodoListActive.FormattingEnabled = true;
            lstTodoListActive.Location = new Point(0, 0);
            lstTodoListActive.Name = "lstTodoListActive";
            lstTodoListActive.Size = new Size(162, 344);
            lstTodoListActive.TabIndex = 13;
            lstTodoListActive.SelectedIndexChanged += lstTasksActive_SelectedIndexChanged;
            // 
            // splTodosActive
            // 
            splTodosActive.Dock = DockStyle.Top;
            splTodosActive.Location = new Point(3, 3);
            splTodosActive.Margin = new Padding(3, 3, 3, 10);
            splTodosActive.Name = "splTodosActive";
            // 
            // splTodosActive.Panel1
            // 
            splTodosActive.Panel1.Controls.Add(lstTodoListActive);
            // 
            // splTodosActive.Panel2
            // 
            splTodosActive.Panel2.Controls.Add(rtxTodoItemDetailsActive);
            splTodosActive.Size = new Size(436, 344);
            splTodosActive.SplitterDistance = 162;
            splTodosActive.TabIndex = 15;
            // 
            // rtxTodoItemDetailsActive
            // 
            rtxTodoItemDetailsActive.Dock = DockStyle.Fill;
            rtxTodoItemDetailsActive.Location = new Point(0, 0);
            rtxTodoItemDetailsActive.Name = "rtxTodoItemDetailsActive";
            rtxTodoItemDetailsActive.ReadOnly = true;
            rtxTodoItemDetailsActive.Size = new Size(270, 344);
            rtxTodoItemDetailsActive.TabIndex = 18;
            rtxTodoItemDetailsActive.Text = "";
            // 
            // grpNewTodoItem
            // 
            grpNewTodoItem.Controls.Add(lblTodoItemTitle);
            grpNewTodoItem.Controls.Add(txtTodoItemTitle);
            grpNewTodoItem.Controls.Add(chkTodoItemImportant);
            grpNewTodoItem.Controls.Add(lblTodoItemLocation);
            grpNewTodoItem.Controls.Add(txtTodoItemLocation);
            grpNewTodoItem.Controls.Add(lblTodoItemDueDate);
            grpNewTodoItem.Controls.Add(btnAddTodoItem);
            grpNewTodoItem.Controls.Add(dtpTodoItemDueDate);
            grpNewTodoItem.Location = new Point(18, 18);
            grpNewTodoItem.Margin = new Padding(0);
            grpNewTodoItem.Name = "grpNewTodoItem";
            grpNewTodoItem.Padding = new Padding(10);
            grpNewTodoItem.Size = new Size(287, 281);
            grpNewTodoItem.TabIndex = 17;
            grpNewTodoItem.TabStop = false;
            grpNewTodoItem.Text = "Add task";
            // 
            // tabTodoList
            // 
            tabTodoList.Controls.Add(tabPageActive);
            tabTodoList.Controls.Add(tabPageFinished);
            tabTodoList.Location = new Point(329, 18);
            tabTodoList.Name = "tabTodoList";
            tabTodoList.SelectedIndex = 0;
            tabTodoList.Size = new Size(450, 411);
            tabTodoList.TabIndex = 14;
            // 
            // tabPageActive
            // 
            tabPageActive.Controls.Add(splTodosActive);
            tabPageActive.Controls.Add(btnFinishTodoItem);
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
            tabPageFinished.Controls.Add(btnReactivateTodoItem);
            tabPageFinished.Controls.Add(splTodosFinished);
            tabPageFinished.Location = new Point(4, 24);
            tabPageFinished.Name = "tabPageFinished";
            tabPageFinished.Padding = new Padding(3);
            tabPageFinished.Size = new Size(442, 383);
            tabPageFinished.TabIndex = 1;
            tabPageFinished.Text = "Finished";
            tabPageFinished.UseVisualStyleBackColor = true;
            // 
            // btnReactivateTodoItem
            // 
            btnReactivateTodoItem.Location = new Point(344, 357);
            btnReactivateTodoItem.Margin = new Padding(0);
            btnReactivateTodoItem.Name = "btnReactivateTodoItem";
            btnReactivateTodoItem.Size = new Size(95, 23);
            btnReactivateTodoItem.TabIndex = 17;
            btnReactivateTodoItem.Text = "Reactivate";
            btnReactivateTodoItem.UseVisualStyleBackColor = true;
            btnReactivateTodoItem.Click += btnReactivateTask_Click;
            // 
            // splTodosFinished
            // 
            splTodosFinished.Dock = DockStyle.Top;
            splTodosFinished.Location = new Point(3, 3);
            splTodosFinished.Name = "splTodosFinished";
            // 
            // splTodosFinished.Panel1
            // 
            splTodosFinished.Panel1.Controls.Add(lstTodoListFinished);
            // 
            // splTodosFinished.Panel2
            // 
            splTodosFinished.Panel2.Controls.Add(rtxTodoItemDetailsFinished);
            splTodosFinished.Size = new Size(436, 344);
            splTodosFinished.SplitterDistance = 164;
            splTodosFinished.TabIndex = 0;
            // 
            // lstTodoListFinished
            // 
            lstTodoListFinished.Dock = DockStyle.Fill;
            lstTodoListFinished.FormattingEnabled = true;
            lstTodoListFinished.Location = new Point(0, 0);
            lstTodoListFinished.Name = "lstTodoListFinished";
            lstTodoListFinished.Size = new Size(164, 344);
            lstTodoListFinished.TabIndex = 0;
            lstTodoListFinished.SelectedIndexChanged += lstTasksFinished_SelectedIndexChanged;
            // 
            // rtxTodoItemDetailsFinished
            // 
            rtxTodoItemDetailsFinished.Dock = DockStyle.Fill;
            rtxTodoItemDetailsFinished.Location = new Point(0, 0);
            rtxTodoItemDetailsFinished.Name = "rtxTodoItemDetailsFinished";
            rtxTodoItemDetailsFinished.ReadOnly = true;
            rtxTodoItemDetailsFinished.Size = new Size(268, 344);
            rtxTodoItemDetailsFinished.TabIndex = 0;
            rtxTodoItemDetailsFinished.Text = "";
            // 
            // formTodoManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabTodoList);
            Controls.Add(grpNewTodoItem);
            Name = "formTodoManager";
            Padding = new Padding(18);
            Text = "Task Manager";
            splTodosActive.Panel1.ResumeLayout(false);
            splTodosActive.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splTodosActive).EndInit();
            splTodosActive.ResumeLayout(false);
            grpNewTodoItem.ResumeLayout(false);
            grpNewTodoItem.PerformLayout();
            tabTodoList.ResumeLayout(false);
            tabPageActive.ResumeLayout(false);
            tabPageFinished.ResumeLayout(false);
            splTodosFinished.Panel1.ResumeLayout(false);
            splTodosFinished.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splTodosFinished).EndInit();
            splTodosFinished.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTodoItemTitle;
        private Label lblTodoItemDueDate;
        private TextBox txtTodoItemTitle;
        private TextBox txtTodoItemLocation;
        private DateTimePicker dtpTodoItemDueDate;
        private CheckBox chkTodoItemImportant;
        private Button btnAddTodoItem;
        private ListBox lstTodoListActive;
        private Button btnFinishTodoItem;
        private GroupBox grpNewTodoItem;
        private RichTextBox rtxTodoItemDetailsActive;
        private TabControl tabTodoList;
        private TabPage tabPageActive;
        private TabPage tabPageFinished;
        private SplitContainer splTodosFinished;
        private ListBox lstTodoListFinished;
        private RichTextBox rtxTodoItemDetailsFinished;
        private Button btnReactivateTodoItem;
        private SplitContainer splTodosActive;
        private Label lblTodoItemLocation;
    }
}
