namespace ClassPriorityTrackerForm
{
    partial class ClassPriorityTrackerForm
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
            taskAndPriorityUserControl1 = new PC2A1ControlLibrary.TaskAndPriorityUserControl();
            SuspendLayout();
            // 
            // taskAndPriorityUserControl1
            // 
            taskAndPriorityUserControl1.Location = new Point(12, 12);
            taskAndPriorityUserControl1.Name = "taskAndPriorityUserControl1";
            taskAndPriorityUserControl1.Size = new Size(511, 338);
            taskAndPriorityUserControl1.TabIndex = 0;
            // 
            // ClassPriorityTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 650);
            Controls.Add(taskAndPriorityUserControl1);
            Name = "ClassPriorityTrackerForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private PC2A1ControlLibrary.TaskAndPriorityUserControl taskAndPriorityUserControl1;
    }
}
