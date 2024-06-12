using System.Windows.Forms;

namespace Assignment6abc
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dateTimePicker = new DateTimePicker();
            DateAndTimeLabel = new Label();
            PriorityLabel = new Label();
            PrioComboBox = new ComboBox();
            TodoLabel = new Label();
            TodoTextBox = new TextBox();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            DescriptionLabel = new Label();
            Priolabel = new Label();
            HourLabel = new Label();
            DateLabel = new Label();
            todoListBox = new ListBox();
            ChangeButton = new Button();
            DelButton = new Button();
            clockTimer = new System.Windows.Forms.Timer(components);
            lblClock = new Label();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitCtrlF4ToolStripMenuItem = new ToolStripMenuItem();
            heloToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(146, 62);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(290, 31);
            dateTimePicker.TabIndex = 1;
            dateTimePicker.Value = new DateTime(2024, 4, 24, 22, 59, 47, 0);
            // 
            // DateAndTimeLabel
            // 
            DateAndTimeLabel.AutoSize = true;
            DateAndTimeLabel.Location = new Point(11, 67);
            DateAndTimeLabel.Name = "DateAndTimeLabel";
            DateAndTimeLabel.Size = new Size(127, 25);
            DateAndTimeLabel.TabIndex = 2;
            DateAndTimeLabel.Text = "Date and Time";
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Location = new Point(441, 67);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(68, 25);
            PriorityLabel.TabIndex = 3;
            PriorityLabel.Text = "Priority";
            // 
            // PrioComboBox
            // 
            PrioComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PrioComboBox.FormattingEnabled = true;
            PrioComboBox.Location = new Point(516, 58);
            PrioComboBox.Name = "PrioComboBox";
            PrioComboBox.Size = new Size(251, 33);
            PrioComboBox.TabIndex = 4;
            // 
            // TodoLabel
            // 
            TodoLabel.AutoSize = true;
            TodoLabel.Location = new Point(11, 127);
            TodoLabel.Name = "TodoLabel";
            TodoLabel.Size = new Size(52, 25);
            TodoLabel.TabIndex = 5;
            TodoLabel.Text = "Todo";
            // 
            // TodoTextBox
            // 
            TodoTextBox.Location = new Point(99, 120);
            TodoTextBox.Name = "TodoTextBox";
            TodoTextBox.Size = new Size(753, 31);
            TodoTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(874, 117);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(111, 33);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DescriptionLabel);
            groupBox1.Controls.Add(Priolabel);
            groupBox1.Controls.Add(HourLabel);
            groupBox1.Controls.Add(DateLabel);
            groupBox1.Controls.Add(todoListBox);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(11, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1067, 312);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "To Do";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.ForeColor = SystemColors.InfoText;
            DescriptionLabel.Location = new Point(611, 43);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(109, 25);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description";
            // 
            // Priolabel
            // 
            Priolabel.AutoSize = true;
            Priolabel.ForeColor = SystemColors.InfoText;
            Priolabel.Location = new Point(391, 43);
            Priolabel.Name = "Priolabel";
            Priolabel.Size = new Size(76, 25);
            Priolabel.TabIndex = 3;
            Priolabel.Text = "Priority";
            // 
            // HourLabel
            // 
            HourLabel.AutoSize = true;
            HourLabel.ForeColor = SystemColors.InfoText;
            HourLabel.Location = new Point(324, 43);
            HourLabel.Name = "HourLabel";
            HourLabel.Size = new Size(54, 25);
            HourLabel.TabIndex = 2;
            HourLabel.Text = "Hour";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.ForeColor = SystemColors.InfoText;
            DateLabel.Location = new Point(21, 43);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(53, 25);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Date";
            // 
            // todoListBox
            // 
            todoListBox.FormattingEnabled = true;
            todoListBox.ItemHeight = 25;
            todoListBox.Location = new Point(14, 68);
            todoListBox.Name = "todoListBox";
            todoListBox.Size = new Size(1043, 229);
            todoListBox.TabIndex = 0;
            todoListBox.SelectedIndexChanged += todoListBox_SelectedIndexChanged;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(114, 548);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(227, 48);
            ChangeButton.TabIndex = 9;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(391, 548);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(227, 48);
            DelButton.TabIndex = 10;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(901, 548);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(56, 25);
            lblClock.TabIndex = 11;
            lblClock.Text = "Timer";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveDataFileToolStripMenuItem, exitCtrlF4ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            newToolStripMenuItem.Size = new Size(321, 34);
            newToolStripMenuItem.Text = "New            ";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(321, 34);
            openToolStripMenuItem.Text = "Open data file";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(321, 34);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // exitCtrlF4ToolStripMenuItem
            // 
            exitCtrlF4ToolStripMenuItem.Name = "exitCtrlF4ToolStripMenuItem";
            exitCtrlF4ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitCtrlF4ToolStripMenuItem.Size = new Size(321, 34);
            exitCtrlF4ToolStripMenuItem.Text = "Exit                     ";
            exitCtrlF4ToolStripMenuItem.Click += exitCtrlF4ToolStripMenuItem_Click;
            // 
            // heloToolStripMenuItem
            // 
            heloToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            heloToolStripMenuItem.Name = "heloToolStripMenuItem";
            heloToolStripMenuItem.Size = new Size(65, 29);
            heloToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, heloToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1146, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 648);
            Controls.Add(lblClock);
            Controls.Add(DelButton);
            Controls.Add(ChangeButton);
            Controls.Add(groupBox1);
            Controls.Add(AddButton);
            Controls.Add(TodoTextBox);
            Controls.Add(TodoLabel);
            Controls.Add(PrioComboBox);
            Controls.Add(PriorityLabel);
            Controls.Add(DateAndTimeLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Todo Reminder By Zahra Khalid";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker;
        private Label DateAndTimeLabel;
        private Label PriorityLabel;
        private ComboBox PrioComboBox;
        private Label TodoLabel;
        private TextBox TodoTextBox;
        private Button AddButton;
        private GroupBox groupBox1;
        private Label DescriptionLabel;
        private Label Priolabel;
        private Label HourLabel;
        private Label DateLabel;
        private ListBox todoListBox;
        private Button ChangeButton;
        private Button DelButton;
        private System.Windows.Forms.Timer clockTimer;
        private Label lblClock;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitCtrlF4ToolStripMenuItem;
        private ToolStripMenuItem heloToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        public ToolStripMenuItem newToolStripMenuItem;
    }
}
