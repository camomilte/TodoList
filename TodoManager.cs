namespace TodoList
{
    public partial class formTodoManager : Form
    {
        // Create list to store todotasks
        private List<TodoItem> todoList = new List<TodoItem>();

        public formTodoManager()
        {
            InitializeComponent();
            lstTodoListActive.DisplayMember = "Title";
            lstTodoListFinished.DisplayMember = "Title";
            RefreshLists();
        }

        private void RefreshLists()
        {
            lstTodoListActive.DataSource = todoList.Where(t => !t.Done).ToList();
            lstTodoListFinished.DataSource = todoList.Where(t => t.Done).ToList();
        }

        #region Button events

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Create todo item
            var todoItem = new TodoItem(
                txtTodoItemTitle.Text,
                txtTodoItemLocation.Text,
                dtpTodoItemDueDate.Value,
                chkTodoItemImportant.Checked,
                false);

            // Add task to list
            todoList.Add(todoItem);
            RefreshLists();

            // Reset inputs
            txtTodoItemTitle.Clear();
            txtTodoItemLocation.Clear();
            dtpTodoItemDueDate.Value = DateTime.Today;
            chkTodoItemImportant.Checked = false;

            // Focus back on first input field
            txtTodoItemTitle.Focus();
        }

        #endregion

        // ACTIVE TASK LIST AND DETAILS EVENTS //
        private void lstTasksActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstTodoListActive.SelectedItem is TodoItem todoItem)
            {
                // Get task details
                rtxTodoItemDetailsActive.Text = todoItem.GetTodoItemDetails();
            }
            else
            {
                // Clear textbox if no tasks
                rtxTodoItemDetailsActive.Clear();
            }
        }

        // FINISH TASK BUTTON EVENTS //
        private void btnFinishTask_Click(object sender, EventArgs e)
        {
            if (lstTodoListActive.SelectedItem is TodoItem todoItem)
            {
                // Change Done to true
                todoItem.Done = true;
                RefreshLists();
                rtxTodoItemDetailsActive.Clear();
            }
        }

        // FINISHED TASK LIST AND DETAILS EVENTS //
        private void lstTasksFinished_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTodoListFinished.SelectedItem is TodoItem todoItem)
            {
                // Get task details
                rtxTodoItemDetailsFinished.Text = todoItem.GetTodoItemDetails();
            }
            else
            {
                // Clear textbox if no tasks
                rtxTodoItemDetailsFinished.Clear();
            }
        }

        // REACTIVATE TASK BUTTON //
        private void btnReactivateTask_Click(object sender, EventArgs e)
        {
            if (lstTodoListFinished.SelectedItem is TodoItem todoItem)
            {
                // Change Done to false
                todoItem.Done = false;
                RefreshLists();
                rtxTodoItemDetailsFinished.Clear();
            }
        }
    }
}
