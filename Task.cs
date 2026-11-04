using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    internal class Task
    {
        private string Title;
        private string Location;
        private DateTime DueDate;
        private bool Important;
        private bool Done;

        public void SetTask(string title, string location, DateTime duedate, bool important, bool done)
        {
            Title = title;
            Location = location;
            DueDate = duedate;
            Important = important;
            Done = done;
        }
    }
}
