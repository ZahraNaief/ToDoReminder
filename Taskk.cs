using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment6abc
{
    public class Taskk
    {
        // Instance variables
        private string description;
        private DateTime dueDateTime;
        private Priority priority;

        // Properties
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DueDateTime
        {
            get { return dueDateTime; }
            set { dueDateTime = value; }
        }

        public Priority Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        // Constructors
        public Taskk()
        {
            // Default constructor
            priority = Priority.Normal;
        }

        public Taskk(string description, DateTime dueDateTime, Priority priority)
        {
            this.description = description;
            this.dueDateTime = dueDateTime;
            this.priority = priority;
        }

        // Methods (if needed)
        // Method to get the time string
        public string GetTimeString()
        {
            // Format the time part of the due date and time
            string timeString = DueDateTime.ToString("HH:mm"); // "HH" for 24-hour format, "hh" for 12-hour format

            return timeString;
        }
        public string GetPriorityString()
        {
            string priorityString = priority.ToString(); // Get the priority enum value as string
                                                         // Replace underscores with spaces
           
            return priorityString;
        }
        public override string ToString()
        {
            string textOut = String.Format("{0, -20}{1, 20}      {2, -20}\t{3, -30}",
                                            dueDateTime.ToLongDateString(),
                                            GetTimeString(),
                                            GetPriorityString(),
                                            Description);
        return textOut;
        }
    }

}
