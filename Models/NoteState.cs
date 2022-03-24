using System;

namespace lab_6.Models
{
    public class NoteState
    {
        public string Title { get; set; } 
        public string Text { get; set; }
        public DateTimeOffset Date { get; set; }

        public NoteState(string name, string description, DateTimeOffset date)
        {
            Date = date;
            Text = description;
            Title = name;
        }
    }
}
