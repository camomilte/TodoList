using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList;

internal class Task
{
    public string Title { get; set; }
    public string Location { get; set; }
    public DateTime DueDate { get; set; }
    public bool Important { get; set; }
    public bool Done { get; set; }

    public Task(string title, string location, DateTime duedate, bool important)
    {
        Title = title;
        Location = location;
        DueDate = duedate;
        Important = important;
    }

    public string GetTaskDetails()
    {
        return $"Title: {Title}{Environment.NewLine}" +
               $"Location: {Location}{Environment.NewLine}" +
               $"Due: {DueDate:d}{Environment.NewLine}" +
               $"Done: {(Done ? "Yes" : "No")}";
    }
}
