
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.Data.Entity;
using System.Diagnostics;


namespace jarvis
{
    public partial class TaskCreator : Form
    {
        private SQLiteConnection sqlite_conn;
        
        private string connectionString;

        public TaskCreator()
        {
            InitializeComponent();
            PriorityBox();
            TaskBox();
            TimePicker();

            connectionString = $"Data Source=database.db;";
            
        }

        private SQLiteConnection CreateConnection()
        {
            try
            {
                sqlite_conn = new SQLiteConnection(connectionString);
                sqlite_conn.Open();  // Attempt to open the connection
                Debug.WriteLine("SQLite connection opened successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening SQLite connection: {ex.Message}");
                sqlite_conn = null;
            }
            return sqlite_conn;
        }
        private void CloseConnection()
        {
            if (sqlite_conn != null && sqlite_conn.State == System.Data.ConnectionState.Open)
            {
                sqlite_conn.Close();
                sqlite_conn.Dispose();  // Dispose of the connection object
                sqlite_conn = null;
                
            }
        }

        

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            CreateTask();
        }

        private void CreateTask()
        {
            try
            {

                // Getting the data from the form
                string task_name = taskName.Text.Trim().ToLower();
                string task_description = taskDescription.Text.Trim().ToLower();
                string task_severity = priorityBox.Text.Trim().ToLower();
                string task_type = taskTypeCombo.SelectedItem?.ToString().ToLower();  // Handle null selection
                string start_time = startTimePicker.Value.ToString("HH:mm");  //  format
                string end_time = endTimePicker.Value.ToString("HH:mm");  //  format

                // Check if any field is empty
                if (string.IsNullOrEmpty(task_name))
                {
                    MessageBox.Show("Task name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    taskName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(task_description))
                {
                    MessageBox.Show("Task description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    taskDescription.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(task_severity))
                {
                    MessageBox.Show("Task severity cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    priorityBox.Focus();
                    return;
                }
                else if (taskTypeCombo.SelectedItem == null)
                {
                    MessageBox.Show("Please select a task type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    taskTypeCombo.Focus();
                    return;
                }


                SQLiteCommand sqlite_cmd;
                sqlite_cmd = CreateConnection().CreateCommand();
                

                sqlite_cmd.CommandText = "INSERT INTO tbl_task(task_name, task_description,task_severity,task_type,start_time,end_time) VALUES('" + task_name + "','" + task_description + "','" + task_severity + "','" + task_type + "','" + start_time + "','" + end_time + "'); ";

                int rowsAffected = sqlite_cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear textboxes after successful insertion
                    taskName.Clear();
                    taskDescription.Clear();
                    priorityBox.SelectedIndex = -1;  // Clear selection
                    taskTypeCombo.SelectedIndex = -1;  // Clear selection
                    startTimePicker.Value = DateTime.Now;  // Reset to current time
                    endTimePicker.Value = DateTime.Now;  // Reset to current time
                }
                else
                {
                    MessageBox.Show("Failed to create task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting data: {ex.Message}");
                sqlite_conn = null;
            }

        }


        private void PriorityBox()
        {
            // Add placeholder text as the first item
            //priorityBox.Items.Add("Priority");
            // Add other items
            priorityBox.Items.Add("High");
            priorityBox.Items.Add("Medium");
            priorityBox.Items.Add("Low");

            // Set placeholder text as initially selected item
            //priorityBox.SelectedIndex = 0;

            priorityBox.SelectedIndexChanged += priorityBox_SelectedIndexChanged;
            priorityBox.KeyPress += priorityBox_KeyPress;

        }

        private void TaskBox()
        {
            // Add placeholder text as the first item
            //  priorityBox.Items.Add("Priority");
            // Add other items
            taskTypeCombo.Items.Add("Degree");
            taskTypeCombo.Items.Add("Data Science");
            taskTypeCombo.Items.Add("DealStreet");

            // Set placeholder text as initially selected item
            //priorityBox.SelectedIndex = 0;



        }

        private void priorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide placeholder if an actual item is selected
            if (priorityBox.SelectedIndex == 0)
            {
                priorityBox.Text = "";
            }
        }

        private void priorityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent typing in the combo box
            e.Handled = true;
        }

        private void TimePicker()
        {

            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "hh:mm tt"; // 12-hour format with AM/PM
            startTimePicker.ShowUpDown = true;
            startTimePicker.Value = DateTime.Now; // Optionally set initial time

            // Handle ValueChanged event to ensure proper display
            startTimePicker.ValueChanged += startTimePicker_ValueChanged;

            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "hh:mm tt"; // 12-hour format with AM/PM
            endTimePicker.ShowUpDown = true;
            endTimePicker.Value = DateTime.Now; // Optionally set initial time

            // Handle ValueChanged event to ensure proper display
            endTimePicker.ValueChanged += endTimePicker_ValueChanged;
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startTimePicker.Text = startTimePicker.Value.ToString("hh:mm tt");

        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endTimePicker.Text = endTimePicker.Value.ToString("hh:mm tt");
        }

        private void TaskCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is closing due to the control box
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent default closing behavior
                e.Cancel = true;

                // Create and show the new form
                jarvis main = new jarvis();
                main.Show();

                // Close this form
                this.Hide(); // Hiding the form

                
                
            }
        }

       
    }
}
