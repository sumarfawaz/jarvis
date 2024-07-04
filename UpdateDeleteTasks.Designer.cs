namespace jarvis
{
    partial class UpdateDeleteTasks
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
            panel1 = new Panel();
            button1 = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            endTimePicker = new DateTimePicker();
            label8 = new Label();
            startTimePicker = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            taskTypeCombo = new ComboBox();
            priorityBox = new ComboBox();
            label4 = new Label();
            taskDescription = new TextBox();
            label3 = new Label();
            taskName = new TextBox();
            label2 = new Label();
            taskId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 13, 28);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(endTimePicker);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(startTimePicker);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(taskTypeCombo);
            panel1.Controls.Add(priorityBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(taskDescription);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(taskName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(taskId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 18, 25);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(467, 353);
            button1.Name = "button1";
            button1.Size = new Size(140, 32);
            button1.TabIndex = 23;
            button1.Text = "Clear All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 18, 25);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(546, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 36);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(321, 353);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 32);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(175, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 32);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update Task";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(401, 267);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 19;
            label7.Text = "End Time";
            // 
            // endTimePicker
            // 
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(487, 267);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(200, 23);
            endTimePicker.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(22, 271);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 17;
            label8.Text = "Start Time";
            // 
            // startTimePicker
            // 
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(115, 269);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(200, 23);
            startTimePicker.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(401, 214);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 15;
            label6.Text = "Task Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(8, 214);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 14;
            label5.Text = "Task Severity";
            // 
            // taskTypeCombo
            // 
            taskTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            taskTypeCombo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskTypeCombo.ForeColor = SystemColors.WindowFrame;
            taskTypeCombo.FormattingEnabled = true;
            taskTypeCombo.Location = new Point(487, 214);
            taskTypeCombo.Name = "taskTypeCombo";
            taskTypeCombo.Size = new Size(200, 23);
            taskTypeCombo.TabIndex = 13;
            // 
            // priorityBox
            // 
            priorityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityBox.ForeColor = SystemColors.WindowFrame;
            priorityBox.FormattingEnabled = true;
            priorityBox.Location = new Point(115, 214);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(200, 23);
            priorityBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(357, 156);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 9;
            label4.Text = "Task Description";
            // 
            // taskDescription
            // 
            taskDescription.Location = new Point(487, 154);
            taskDescription.Name = "taskDescription";
            taskDescription.Size = new Size(200, 23);
            taskDescription.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(22, 156);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 7;
            label3.Text = "Task Name";
            // 
            // taskName
            // 
            taskName.Location = new Point(115, 154);
            taskName.Name = "taskName";
            taskName.Size = new Size(200, 23);
            taskName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(166, 71);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 5;
            label2.Text = "Task ID";
            // 
            // taskId
            // 
            taskId.Location = new Point(232, 71);
            taskId.Name = "taskId";
            taskId.Size = new Size(297, 23);
            taskId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 27);
            label1.TabIndex = 2;
            label1.Text = "Update/Delete Task";
            // 
            // UpdateDeleteTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "UpdateDeleteTasks";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update/Delete Task";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox taskId;
        private Label label2;
        private Label label4;
        private TextBox taskDescription;
        private Label label3;
        private TextBox taskName;
        private ComboBox taskTypeCombo;
        private ComboBox priorityBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker endTimePicker;
        private Label label8;
        private DateTimePicker startTimePicker;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Button button1;
    }
}