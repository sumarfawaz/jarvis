namespace jarvis
{
    partial class jarvis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel4 = new Panel();
            date = new Label();
            label1 = new Label();
            panel3 = new Panel();
            time = new Label();
            panel2 = new Panel();
            button2 = new Button();
            btnCreateTask = new Button();
            viewRoutine = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 13, 28);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 100);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 13, 28);
            panel4.Controls.Add(date);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(214, 100);
            panel4.TabIndex = 2;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.ForeColor = SystemColors.Control;
            date.Location = new Point(66, 38);
            date.Name = "date";
            date.Size = new Size(53, 27);
            date.TabIndex = 3;
            date.Text = "date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(448, 38);
            label1.Name = "label1";
            label1.Size = new Size(117, 27);
            label1.TabIndex = 1;
            label1.Text = "J.A.R.V.I.S";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 13, 28);
            panel3.Controls.Add(time);
            panel3.Location = new Point(847, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 100);
            panel3.TabIndex = 1;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time.ForeColor = SystemColors.Control;
            time.Location = new Point(28, 38);
            time.Margin = new Padding(10);
            time.Name = "time";
            time.Size = new Size(54, 27);
            time.TabIndex = 0;
            time.Text = "time";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 13, 28);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnCreateTask);
            panel2.Controls.Add(viewRoutine);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 49);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 25, 52);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(639, 0);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(203, 49);
            button2.TabIndex = 5;
            button2.Text = "Break Mode";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnCreateTask
            // 
            btnCreateTask.BackColor = Color.FromArgb(0, 25, 51);
            btnCreateTask.FlatAppearance.BorderColor = Color.FromArgb(0, 25, 52);
            btnCreateTask.ForeColor = SystemColors.Control;
            btnCreateTask.Location = new Point(390, 0);
            btnCreateTask.Margin = new Padding(10);
            btnCreateTask.Name = "btnCreateTask";
            btnCreateTask.Padding = new Padding(10);
            btnCreateTask.Size = new Size(243, 49);
            btnCreateTask.TabIndex = 4;
            btnCreateTask.Text = "Create New Task";
            btnCreateTask.UseVisualStyleBackColor = false;
            btnCreateTask.Click += btnCreateTask_Click;
            // 
            // viewRoutine
            // 
            viewRoutine.BackColor = Color.FromArgb(0, 25, 52);
            viewRoutine.FlatAppearance.BorderColor = Color.FromArgb(0, 25, 52);
            viewRoutine.ForeColor = SystemColors.Control;
            viewRoutine.Location = new Point(169, 0);
            viewRoutine.Margin = new Padding(10);
            viewRoutine.Name = "viewRoutine";
            viewRoutine.Padding = new Padding(10);
            viewRoutine.Size = new Size(214, 49);
            viewRoutine.TabIndex = 3;
            viewRoutine.Text = "View Routine";
            viewRoutine.UseVisualStyleBackColor = false;
            viewRoutine.Click += viewRoutine_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 155);
            panel5.Name = "panel5";
            panel5.Size = new Size(992, 464);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(550, 330);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 11;
            label7.Text = "countdown";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(337, 330);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 10;
            label6.Text = "TIME LEFT :";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 25, 52);
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 25, 52);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(259, 376);
            button4.Margin = new Padding(10);
            button4.Name = "button4";
            button4.Padding = new Padding(10);
            button4.Size = new Size(214, 49);
            button4.TabIndex = 9;
            button4.Text = "Next Task";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 25, 52);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(521, 376);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Padding = new Padding(10);
            button3.Size = new Size(203, 49);
            button3.TabIndex = 8;
            button3.Text = "Task Complete";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(448, 259);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 43);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(259, 270);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 6;
            label5.Text = "NEXT TASK          : ";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(448, 186);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 43);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(259, 197);
            label4.Name = "label4";
            label4.Size = new Size(178, 23);
            label4.TabIndex = 4;
            label4.Text = "END TIME            : ";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(448, 112);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 43);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(259, 123);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 2;
            label3.Text = "START TIME         : ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(448, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 43);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(259, 46);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 0;
            label2.Text = "CURRENT TASK  : ";
            // 
            // jarvis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 25, 51);
            ClientSize = new Size(992, 619);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "jarvis";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "J.A.R.V.I.S";
            FormClosing += jarvis_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label time;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Panel panel4;
        private Label date;
        private Button viewRoutine;
        private Button btnCreateTask;
        private Button button2;
        private Panel panel5;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button3;
        private Button button4;
        private Label label6;
        private Label label7;
    }
}