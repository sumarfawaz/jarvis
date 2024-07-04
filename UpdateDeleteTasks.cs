using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jarvis
{
    public partial class UpdateDeleteTasks : Form
    {
        private SQLiteConnection sqlite_conn;

        public UpdateDeleteTasks()
        {
            InitializeComponent();
            PriorityBox();
            TaskBox();
            TimePicker();
            sqlite_conn = CreateConnection();

        }

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source=database.db;");
            conn.Open();
            return conn;
        }


        private void GetTaskInfo()
        {
            // Read and trim task_id input from TextBox
            string task_id_string = taskId.Text.Trim();

            // Initialize task_id as int
            int task_id;

            // Attempt to parse task_id_string to int
            if (int.TryParse(task_id_string, out task_id))
            {
                // Use parameterized query to prevent SQL injection
                string query = "SELECT task_name, task_description, task_severity, task_type, start_time, end_time " +
                               "FROM tbl_task WHERE task_id = @TaskId;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
                {
                    cmd.Parameters.AddWithValue("@TaskId", task_id);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate controls with data from database
                            taskName.Text = reader["task_name"].ToString();
                            taskDescription.Text = reader["task_description"].ToString();
                            priorityBox.Text = reader["task_severity"].ToString();
                            taskTypeCombo.Text = reader["task_type"].ToString();

                            // DateTime values (assuming they are stored as DateTime in the database)
                            startTimePicker.Value = Convert.ToDateTime(reader["start_time"]);
                            endTimePicker.Value = Convert.ToDateTime(reader["end_time"]);
                        }
                        else
                        {
                            MessageBox.Show("Task ID not found in the database.");
                            // Clear controls or handle as appropriate
                            taskName.Text = "";
                            taskDescription.Text = "";
                            priorityBox.Text = "";
                            taskTypeCombo.Text = "";
                            startTimePicker.Value = DateTime.Now;
                            endTimePicker.Value = DateTime.Now;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid task ID format. Please enter a valid number.");
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



        }

        private void TaskBox()
        {

            taskTypeCombo.Items.Add("Degree");
            taskTypeCombo.Items.Add("Data Science");
            taskTypeCombo.Items.Add("DealStreet");

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Read task_id from TextBox and trim any extra spaces
            string task_id_string = taskId.Text.Trim();

            // Initialize task_id as int
            int task_id;

            // Attempt to parse task_id_string to int
            if (int.TryParse(task_id_string, out task_id))
            {
                // Read updated values from form controls
                string taskNameValue = taskName.Text.Trim();
                string taskDescriptionValue = taskDescription.Text.Trim();
                string priorityValue = priorityBox.Text.Trim();
                string taskTypeValue = taskTypeCombo.Text.Trim();
                DateTime startTimeValue = startTimePicker.Value;
                DateTime endTimeValue = endTimePicker.Value;

                // SQL query to update task based on task_id
                string query = @"UPDATE tbl_task 
                         SET task_name = @TaskName, 
                             task_description = @TaskDescription, 
                             task_severity = @TaskSeverity, 
                             task_type = @TaskType, 
                             start_time = @StartTime, 
                             end_time = @EndTime 
                         WHERE task_id = @TaskId;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
                {
                    cmd.Parameters.AddWithValue("@TaskName", taskNameValue);
                    cmd.Parameters.AddWithValue("@TaskDescription", taskDescriptionValue);
                    cmd.Parameters.AddWithValue("@TaskSeverity", priorityValue);
                    cmd.Parameters.AddWithValue("@TaskType", taskTypeValue);
                    cmd.Parameters.AddWithValue("@StartTime", startTimeValue);
                    cmd.Parameters.AddWithValue("@EndTime", endTimeValue);
                    cmd.Parameters.AddWithValue("@TaskId", task_id);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task updated successfully.");
                            // Optionally refresh data or UI after update
                            GetTaskInfo(); // Refresh displayed task info
                        }
                        else
                        {
                            MessageBox.Show("Task update failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating task: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid task ID format. Please enter a valid number.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetTaskInfo();
        }

        private void ClearForm()
        {
            // Clear all TextBoxes and ComboBoxes
            taskName.Text = "";
            taskDescription.Text = "";
            priorityBox.SelectedIndex = -1; // Clear selected item
            taskTypeCombo.SelectedIndex = -1; // Clear selected item
            startTimePicker.Value = DateTime.Now; // Reset to current time
            endTimePicker.Value = DateTime.Now; // Reset to current time
            taskId.Text = ""; // Clear taskId TextBox
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Read task_id from TextBox and trim any extra spaces
            string task_id_string = taskId.Text.Trim();

            // Initialize task_id as int
            int task_id;

            // Attempt to parse task_id_string to int
            if (int.TryParse(task_id_string, out task_id))
            {
                // SQL query to delete task based on task_id
                string query = "DELETE FROM tbl_task WHERE task_id = @TaskId;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, sqlite_conn))
                {
                    cmd.Parameters.AddWithValue("@TaskId", task_id);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Task deleted successfully.");
                            // Optionally clear form fields or refresh data/UI after deletion
                            ClearForm(); // Example method to clear form fields

                        }
                        else
                        {
                            MessageBox.Show("Task deletion failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting task: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid task ID format. Please enter a valid number.");
            }
        }

        private void UpdateDeleteTasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the form is closing due to the control box
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent default closing behavior
                e.Cancel = true;

                // Create and show the new form
                TasksForm main = new TasksForm();
                main.Show();

                // Close this form
                this.Hide(); // Hiding the form



            }
        }
    }
}
