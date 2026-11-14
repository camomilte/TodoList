using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList;

internal class TodoItem
{
    public string Title { get; set; }
    public string Location { get; set; }
    public DateTime DueDate { get; set; }
    public bool Important { get; set; }
    public bool Done { get; set; }

    public TodoItem(string title, string location, DateTime duedate, bool important, bool done)
    {
        Title = title;
        Location = location;
        DueDate = duedate;
        Important = important;
        Done = done;
    }

    // Get TodoItem details formatted
    public string GetTodoItemDetails()
    {
        return $"Title: {Title}{Environment.NewLine}" +
               $"Location: {Location}{Environment.NewLine}" +
               $"Due: {DueDate:d}{Environment.NewLine}" +
               $"Important: {(Important ? "Yes" : "No")}";
    }
}
