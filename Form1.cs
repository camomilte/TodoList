using System.ComponentModel;

namespace TodoList
{
    public partial class formTaskManager : Form
    {
        // Create list to store tasks
        private BindingList<Task> tasks = new BindingList<Task>();
        public formTaskManager()
        {
            InitializeComponent();
            lstTasksActive.DataSource = tasks;
            lstTasksActive.DisplayMember = "Title";
        }

        // ADD BUTTON EVENTS //
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Create task
            var task = new Task(
                txtTaskTitle.Text,
                txtLocation.Text,
                dtpTaskDueDate.Value,
                chkImportant.Checked);

            // Add task to list
            tasks.Add(task);

            // Reset inputs
            txtTaskTitle.Clear();
            txtLocation.Clear();
            dtpTaskDueDate.Value = DateTime.Today;
            chkImportant.Checked = false;

            // Focus back on first input field
            txtTaskTitle.Focus();
        }

        // TASK LIST AND DETAILS EVENTS //
        private void lstTasksActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasksActive.SelectedItem is Task task)
            {
                // Get task details
                rtxTaskDetailsActive.Text = task.GetTaskDetails();
            }
            else
            {
                // Clear textbox if no tasks
                rtxTaskDetailsActive.Clear();
            }
        }

        // FINISH TASK BUTTON EVENTS //
        private void btnFinishTask_Click(object sender, EventArgs e)
        {
            if (lstTasksActive.SelectedItem is Task task)
            {
                // Change Done to true
                task.Done = true;
            }
        }
    }
}
