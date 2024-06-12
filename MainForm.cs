using System;

namespace Assignment6abc
{
    public partial class MainForm : Form
    {

        private TaskManager taskManager;

        //working with only one file located in the same directory  
        //as the application's EXE- file  
        string fileName = Application.StartupPath + "\\Tasks.txt";
        ToolTip toolTip = new ToolTip();

        private void initializeGUI()
        {
            ChangeButton.Enabled = false;
            DelButton.Enabled = false;
            PrioComboBox.Items.Clear();
            PrioComboBox.Items.AddRange(Enum.GetNames(typeof(Priority)));
            PrioComboBox.SelectedIndex = (int)Priority.Normal;
            lblClock.Text = string.Empty;
            todoListBox.Items.Clear();
            clockTimer.Start();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd  HH:mm";
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(dateTimePicker, "Click to open calender for date, write in time here.");
            toolTip.SetToolTip(PrioComboBox, "Select the priority");

            string tips = "To Change: Select an item first!" + Environment.NewLine;
            tips += "Make you changes in the input button controls," + Environment.NewLine;
            tips += "Click the Change button." + Environment.NewLine;

            toolTip.SetToolTip(todoListBox, tips);
            toolTip.SetToolTip(ChangeButton, tips);

            string deltips = "Select an item first and then click delete button!";
            toolTip.SetToolTip(DelButton, deltips);

            string desTips = "Write reminder's description here!";
            toolTip.SetToolTip(DescriptionLabel, desTips);



        }

        public MainForm()
        {
            InitializeComponent();
            initializeGUI();
            taskManager = new TaskManager();
         
        }

        private void LoadPrioritiesIntoComboBox()
        {
            foreach (Priority priority in Enum.GetValues(typeof(Priority)))
            {
                PrioComboBox.Items.Add(priority);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Read input and add the task to the TaskManager
            AddTask();
        }

        private void AddTask()
        {
            // Read input from controls and create a new Task object
            string description = TodoTextBox.Text; // Assuming txtDescription is a TextBox control for entering task description
            DateTime dueDateTime = dateTimePicker.Value;
            Priority priority = (Priority)PrioComboBox.SelectedIndex;

            // Create a new Task object
            Taskk newTask = new Taskk(description, dueDateTime, priority);

            // Add the new task to the TaskManager
            taskManager.AddTask(newTask);

            // Update the Main form
            UpdateGui();
        }
        private void UpdateButtonStates()
        {
            bool hasItems = todoListBox.Items.Count > 0;
            bool isItemSelected = todoListBox.SelectedItems.Count > 0;

            ChangeButton.Enabled = hasItems && isItemSelected;
            DelButton.Enabled = hasItems && isItemSelected;
        }

        // Method to update the To-Do list in the ListBox
        private void UpdateGui()
        {
            // Clear input controls here
            TodoTextBox.Text = "";

            // Clear the existing items in the ListBox
            todoListBox.Items.Clear();

            PrioComboBox.SelectedIndex = (int)Priority.Normal;
            // Get all tasks from the TaskManager
            string[] infoString = taskManager.GetTaskStrings();

            // Add each task's string representation to the ListBox
            foreach (string ind in infoString)
            {
                todoListBox.Items.Add(ind);
            }
            UpdateButtonStates();
        }
        private void ClearInputControls()
        {
            // Clear input controls here
            TodoTextBox.Text = "";
            // Clear other input controls as needed
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void exitCtrlF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure About this?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes
            if (result == DialogResult.Yes)
            {
                // Close the form
                Close();
            }
        }
        // Event handler for when a task is selected in the ListBox
        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected task
            Taskk selectedTask = taskManager.GetTaskAtIndex(todoListBox.SelectedIndex);
            if (todoListBox.SelectedIndex != -1)
            {
                // Populate the input fields with the data of the selected task
                TodoTextBox.Text = selectedTask.Description;
                dateTimePicker.Value = selectedTask.DueDateTime;
                PrioComboBox.SelectedIndex = (int)selectedTask.Priority;
            }
            UpdateButtonStates();
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Really?Theres no going back!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Remove the selected task from the TaskManager
                    taskManager.DeleteTaskAtIndex(todoListBox.SelectedIndex);

                    // Remove the selected item from the ListBox
                    todoListBox.Items.RemoveAt(todoListBox.SelectedIndex);

                    UpdateGui();
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("You want to change it!", "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Get the selected task
                    Taskk selectedTask = taskManager.GetTaskAtIndex(todoListBox.SelectedIndex);

                    // Create a new task with the modified data
                    Taskk newTask = new Taskk
                    {
                        Description = TodoTextBox.Text,
                        DueDateTime = dateTimePicker.Value,
                        Priority = (Priority)PrioComboBox.SelectedIndex
                    };

                    // Change the selected task with the new task data
                    taskManager.ChangeTask(todoListBox.SelectedIndex, newTask);

                    // Update the ListBox to reflect the changes
                    UpdateGui();
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder to change.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Task Data";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    string errMessage = "Something went wrong while saving data to file";
                    bool ok = taskManager.WriteDataToFile(fileName);
                    if (!ok)
                        MessageBox.Show(errMessage);
                    else
                        MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open Task Data";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    string errMessage = "Something went wrong when opening the file";
                    bool ok = taskManager.ReadDataFromFile(fileName);
                    if (!ok)
                        MessageBox.Show(errMessage);
                    else
                        UpdateGui();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeGUI();
        }
      
    }
}
