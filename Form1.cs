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
            lstTasks.DataSource = tasks;
            lstTasks.DisplayMember = "Title";
        }

        // Add Task button click events
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
    }
}
