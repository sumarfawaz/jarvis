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
    public partial class TasksForm : Form
    {
        private SQLiteConnection sqlite_conn;


        public TasksForm()
        {
            InitializeComponent();
            sqlite_conn = CreateConnection();
            LoadTasks();
            //DataGridView();
        }

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source=database.db;");
            conn.Open();
            return conn;
        }

        private void DataGridView()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoGenerateColumns = false; // Manually add columns

            // Add columns for data
            dataGridView1.Columns.Add("task_name", "Task Name");
            dataGridView1.Columns.Add("task_description", "Description");
            dataGridView1.Columns.Add("task_severity", "Severity");
            dataGridView1.Columns.Add("task_type", "Type");
            dataGridView1.Columns.Add("start_time", "Start Time");
            dataGridView1.Columns.Add("end_time", "End Time");

            // Add column for Update button
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(updateButtonColumn);

            // Add column for Delete button
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButtonColumn);

            // Set DataGridView properties
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Columns fill the DataGridView
            dataGridView1.AllowUserToAddRows = false; // Disable user adding rows
            dataGridView1.ReadOnly = true; // Make cells read-only
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add DataGridView to form controls
            Controls.Add(dataGridView1);

        }

        private void LoadTasks()
        {


            string query = "SELECT task_id,task_name,task_description,task_severity,task_type,start_time,end_time FROM tbl_task ORDER BY start_time DESC;";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, sqlite_conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            // Assign DataTable as DataGridView DataSource
            dataGridView1.DataSource = dataTable;

            // Set column headers and formatting
            dataGridView1.Columns["task_id"].HeaderText = "Task ID";
            dataGridView1.Columns["task_name"].HeaderText = "Task Name";
            dataGridView1.Columns["task_description"].HeaderText = "Description";
            dataGridView1.Columns["task_severity"].HeaderText = "Severity";
            dataGridView1.Columns["task_type"].HeaderText = "Type";
            dataGridView1.Columns["start_time"].HeaderText = "Start Time";
            dataGridView1.Columns["end_time"].HeaderText = "End Time";

            // Add DataGridViewButtonColumn for Update
            //DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            //updateButtonColumn.HeaderText = "";
            //updateButtonColumn.Text = "Update";
            //updateButtonColumn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(updateButtonColumn);

            // Add DataGridViewButtonColumn for Delete
            //DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            //deleteButtonColumn.HeaderText = "";
            //deleteButtonColumn.Text = "Delete";
            //deleteButtonColumn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(deleteButtonColumn);

            // Refresh DataGridView
            dataGridView1.Refresh();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateAndDelete_Click(object sender, EventArgs e)
        {
            UpdateDeleteTasks updateDeleteTasks = new UpdateDeleteTasks();
            updateDeleteTasks.Show();
            this.Hide();

        }

        private void TasksForm_FormClosing(object sender, FormClosingEventArgs e)
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
