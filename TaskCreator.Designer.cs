namespace jarvis
{
    partial class TaskCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            btnCreateTask = new Button();
            label7 = new Label();
            taskTypeCombo = new ComboBox();
            label6 = new Label();
            endTimePicker = new DateTimePicker();
            label5 = new Label();
            startTimePicker = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            priorityBox = new ComboBox();
            taskDescription = new TextBox();
            taskName = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 25, 52);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCreateTask);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(taskTypeCombo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(endTimePicker);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(startTimePicker);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(priorityBox);
            panel3.Controls.Add(taskDescription);
            panel3.Controls.Add(taskName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 400);
            panel3.TabIndex = 1;
            // 
            // btnCreateTask
            // 
            btnCreateTask.BackColor = Color.ForestGreen;
            btnCreateTask.FlatAppearance.BorderColor = Color.FromArgb(0, 25, 52);
            btnCreateTask.ForeColor = SystemColors.Control;
            btnCreateTask.Location = new Point(318, 332);
            btnCreateTask.Margin = new Padding(10);
            btnCreateTask.Name = "btnCreateTask";
            btnCreateTask.Padding = new Padding(10);
            btnCreateTask.Size = new Size(177, 49);
            btnCreateTask.TabIndex = 13;
            btnCreateTask.Text = "Create Task";
            btnCreateTask.UseVisualStyleBackColor = false;
            btnCreateTask.Click += btnCreateTask_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(430, 186);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 12;
            label7.Text = "Task Type";
            // 
            // taskTypeCombo
            // 
            taskTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            taskTypeCombo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskTypeCombo.ForeColor = SystemColors.WindowFrame;
            taskTypeCombo.FormattingEnabled = true;
            taskTypeCombo.Location = new Point(430, 210);
            taskTypeCombo.Name = "taskTypeCombo";
            taskTypeCombo.Size = new Size(213, 23);
            taskTypeCombo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(430, 257);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 10;
            label6.Text = "End Time";
            // 
            // endTimePicker
            // 
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(430, 280);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(213, 23);
            endTimePicker.TabIndex = 9;
            endTimePicker.ValueChanged += endTimePicker_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(169, 256);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 8;
            label5.Text = "Start Time";
            // 
            // startTimePicker
            // 
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(168, 280);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(229, 23);
            startTimePicker.TabIndex = 7;
            startTimePicker.ValueChanged += startTimePicker_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(169, 186);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 6;
            label4.Text = "Task Severity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(168, 116);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 5;
            label3.Text = "Task Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(169, 51);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Task Name";
            // 
            // priorityBox
            // 
            priorityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityBox.ForeColor = SystemColors.WindowFrame;
            priorityBox.FormattingEnabled = true;
            priorityBox.Location = new Point(168, 210);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(229, 23);
            priorityBox.TabIndex = 3;
            priorityBox.SelectedIndexChanged += priorityBox_SelectedIndexChanged;
            priorityBox.KeyPress += priorityBox_KeyPress;
            // 
            // taskDescription
            // 
            taskDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskDescription.Location = new Point(168, 140);
            taskDescription.Name = "taskDescription";
            taskDescription.Size = new Size(475, 23);
            taskDescription.TabIndex = 2;
            // 
            // taskName
            // 
            taskName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskName.Location = new Point(168, 75);
            taskName.Name = "taskName";
            taskName.Size = new Size(475, 23);
            taskName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 13, 28);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 0;
            label1.Text = "Create New Task";
            // 
            // TaskCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "TaskCreator";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Task";
            FormClosing += TaskCreator_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox taskName;
        private TextBox taskDescription;
        private ComboBox priorityBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker startTimePicker;
        private Label label6;
        private DateTimePicker endTimePicker;
        private Label label5;
        private Label label7;
        private ComboBox taskTypeCombo;
        private Button btnCreateTask;
    }
}