namespace PC2A1ControlLibrary
{
    partial class TaskAndPriorityUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            priorityGroupBox = new GroupBox();
            lowRadioButton = new RadioButton();
            mediumRadioButton = new RadioButton();
            highRadioButton = new RadioButton();
            taskDataGridView = new DataGridView();
            DoneColumn = new DataGridViewCheckBoxColumn();
            TaskColumn = new DataGridViewTextBoxColumn();
            priorityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            SuspendLayout();
            // 
            // priorityGroupBox
            // 
            priorityGroupBox.Controls.Add(lowRadioButton);
            priorityGroupBox.Controls.Add(mediumRadioButton);
            priorityGroupBox.Controls.Add(highRadioButton);
            priorityGroupBox.Location = new Point(3, 17);
            priorityGroupBox.Name = "priorityGroupBox";
            priorityGroupBox.Size = new Size(113, 101);
            priorityGroupBox.TabIndex = 1;
            priorityGroupBox.TabStop = false;
            priorityGroupBox.Text = "Priority";
            // 
            // lowRadioButton
            // 
            lowRadioButton.AutoSize = true;
            lowRadioButton.Location = new Point(6, 72);
            lowRadioButton.Name = "lowRadioButton";
            lowRadioButton.Size = new Size(47, 19);
            lowRadioButton.TabIndex = 4;
            lowRadioButton.TabStop = true;
            lowRadioButton.Text = "Low";
            lowRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            mediumRadioButton.AutoSize = true;
            mediumRadioButton.Location = new Point(6, 47);
            mediumRadioButton.Name = "mediumRadioButton";
            mediumRadioButton.Size = new Size(70, 19);
            mediumRadioButton.TabIndex = 3;
            mediumRadioButton.TabStop = true;
            mediumRadioButton.Text = "Medium";
            mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // highRadioButton
            // 
            highRadioButton.AutoSize = true;
            highRadioButton.Location = new Point(6, 22);
            highRadioButton.Name = "highRadioButton";
            highRadioButton.Size = new Size(51, 19);
            highRadioButton.TabIndex = 2;
            highRadioButton.TabStop = true;
            highRadioButton.Text = "High";
            highRadioButton.UseVisualStyleBackColor = true;
            // 
            // taskDataGridView
            // 
            taskDataGridView.AllowUserToAddRows = false;
            taskDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Columns.AddRange(new DataGridViewColumn[] { DoneColumn, TaskColumn });
            taskDataGridView.Location = new Point(122, 17);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.Size = new Size(378, 309);
            taskDataGridView.TabIndex = 2;
            // 
            // DoneColumn
            // 
            DoneColumn.HeaderText = "Done";
            DoneColumn.Name = "DoneColumn";
            DoneColumn.ReadOnly = true;
            // 
            // TaskColumn
            // 
            TaskColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TaskColumn.HeaderText = "Task";
            TaskColumn.Name = "TaskColumn";
            TaskColumn.ReadOnly = true;
            // 
            // TaskAndPriorityUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskDataGridView);
            Controls.Add(priorityGroupBox);
            Name = "TaskAndPriorityUserControl";
            Size = new Size(511, 338);
            Load += this.TaskAndPriorityUserControl_Load;
            priorityGroupBox.ResumeLayout(false);
            priorityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox priorityGroupBox;
        private RadioButton lowRadioButton;
        private RadioButton mediumRadioButton;
        private RadioButton highRadioButton;
        private DataGridView taskDataGridView;
        private DataGridViewCheckBoxColumn DoneColumn;
        private DataGridViewTextBoxColumn TaskColumn;
    }
}
