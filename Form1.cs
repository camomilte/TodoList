using System.ComponentModel;

namespace TodoList
{
    public partial class formTaskManager : Form
    {
        // Create list to store tasks
        private List<Task> tasks = new List<Task>();

        public formTaskManager()
        {
            InitializeComponent();
            lstTasksActive.DisplayMember = "Title";
            lstTasksFinished.DisplayMember = "Title";
            RefreshLists();
        }

        private void RefreshLists()
        {
            lstTasksActive.DataSource = tasks.Where(t => !t.Done).ToList();
            lstTasksFinished.DataSource = tasks.Where(t => t.Done).ToList();
        }

        // ADD BUTTON EVENTS //
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Create task
            var task = new Task(
                txtTaskTitle.Text,
                txtLocation.Text,
                dtpTaskDueDate.Value,
                chkImportant.Checked,
                false);

            // Add task to list
            tasks.Add(task);
            RefreshLists();

            // Reset inputs
            txtTaskTitle.Clear();
            txtLocation.Clear();
            dtpTaskDueDate.Value = DateTime.Today;
            chkImportant.Checked = false;

            // Focus back on first input field
            txtTaskTitle.Focus();
        }

        // ACTIVE TASK LIST AND DETAILS EVENTS //
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
                RefreshLists();
                rtxTaskDetailsActive.Clear();
            }
        }

        // FINISHED TASK LIST AND DETAILS EVENTS //
        private void lstTasksFinished_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasksFinished.SelectedItem is Task task)
            {
                // Get task details
                rtxTaskDetailsFinished.Text = task.GetTaskDetails();
            }
            else
            {
                // Clear textbox if no tasks
                rtxTaskDetailsFinished.Clear();
            }
        }

        // REACTIVATE TASK BUTTON //
        private void btnReactivateTask_Click(object sender, EventArgs e)
        {

        }
    }
}
