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

        #region Helpers
        private void RefreshLists()
        {
            lstTodoListActive.DataSource = todoList.Where(t => !t.Done).ToList();
            lstTodoListFinished.DataSource = todoList.Where(t => t.Done).ToList();
        }
        #endregion

        #region Add todo

        private void btnAddTodoItem_Click(object sender, EventArgs e)
        {
            // Create todo item
            var todoItem = new TodoItem(
                txtTodoItemTitle.Text,
                txtTodoItemLocation.Text,
                dtpTodoItemDueDate.Value,
                chkTodoItemImportant.Checked,
                false);

            // Add todo to list
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

        #region Active todos
        private void lstTodoListActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstTodoListActive.SelectedItem is TodoItem todoItem)
            {
                // Get todo details
                rtxTodoItemDetailsActive.Text = todoItem.GetTodoItemDetails();
            }
            else
            {
                // Clear textbox if no todos
                rtxTodoItemDetailsActive.Clear();
            }
        }

        private void btnFinishTodoItem_Click(object sender, EventArgs e)
        {
            if (lstTodoListActive.SelectedItem is TodoItem todoItem)
            {
                // Change Done to true
                todoItem.Done = true;
                RefreshLists();
                rtxTodoItemDetailsActive.Clear();
            }
        }
        #endregion

        #region Finished todos
        private void lstTodoListFinished_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTodoListFinished.SelectedItem is TodoItem todoItem)
            {
                // Get todo details
                rtxTodoItemDetailsFinished.Text = todoItem.GetTodoItemDetails();
            }
            else
            {
                // Clear textbox if no todos
                rtxTodoItemDetailsFinished.Clear();
            }
        }

        private void btnReactivateTodoItem_Click(object sender, EventArgs e)
        {
            if (lstTodoListFinished.SelectedItem is TodoItem todoItem)
            {
                // Change Done to false
                todoItem.Done = false;
                RefreshLists();
                rtxTodoItemDetailsFinished.Clear();
            }
        }
        #endregion
    }
}