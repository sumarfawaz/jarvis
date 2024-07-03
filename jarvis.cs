using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace jarvis
{
    public partial class jarvis : Form
    {


        public jarvis()
        {
            InitializeComponent();

            // Initial update of the time
            UpdateTime();
            // Set the date
            UpdateDate();

        }



        private void UpdateTime()
        {
            var currentTime = TimeOnly.FromDateTime(DateTime.Now);
            time.Text = currentTime.ToString();
        }

        private void UpdateDate()
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            date.Text = today.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            TaskCreator formNewTask = new TaskCreator();
            formNewTask.Show();
            this.Dispose();
        }

        private void jarvis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
