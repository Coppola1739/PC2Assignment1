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
            trackerTabControl = new TabControl();
            classTabPage1 = new TabPage();
            taskAndPriorityUserControl1 = new PC2A1ControlLibrary.TaskAndPriorityUserControl();
            classTabPage2 = new TabPage();
            taskAndPriorityUserControl2 = new PC2A1ControlLibrary.TaskAndPriorityUserControl();
            tabPage1 = new TabPage();
            taskAndPriorityUserControl3 = new PC2A1ControlLibrary.TaskAndPriorityUserControl();
            outputTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            menulStripMenuItem = new ToolStripMenuItem();
            trackerTabControl.SuspendLayout();
            classTabPage1.SuspendLayout();
            classTabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // trackerTabControl
            // 
            trackerTabControl.Controls.Add(classTabPage1);
            trackerTabControl.Controls.Add(classTabPage2);
            trackerTabControl.Controls.Add(tabPage1);
            trackerTabControl.Location = new Point(12, 27);
            trackerTabControl.Name = "trackerTabControl";
            trackerTabControl.SelectedIndex = 0;
            trackerTabControl.Size = new Size(544, 360);
            trackerTabControl.TabIndex = 0;
            // 
            // classTabPage1
            // 
            classTabPage1.Controls.Add(taskAndPriorityUserControl1);
            classTabPage1.Location = new Point(4, 24);
            classTabPage1.Name = "classTabPage1";
            classTabPage1.Padding = new Padding(3);
            classTabPage1.Size = new Size(536, 332);
            classTabPage1.TabIndex = 0;
            classTabPage1.Text = "Math";
            classTabPage1.UseVisualStyleBackColor = true;
            // 
            // taskAndPriorityUserControl1
            // 
            taskAndPriorityUserControl1.Location = new Point(0, 0);
            taskAndPriorityUserControl1.Name = "taskAndPriorityUserControl1";
            taskAndPriorityUserControl1.Size = new Size(524, 338);
            taskAndPriorityUserControl1.TabIndex = 0;
            // 
            // classTabPage2
            // 
            classTabPage2.Controls.Add(taskAndPriorityUserControl2);
            classTabPage2.Location = new Point(4, 24);
            classTabPage2.Name = "classTabPage2";
            classTabPage2.Padding = new Padding(3);
            classTabPage2.Size = new Size(536, 332);
            classTabPage2.TabIndex = 1;
            classTabPage2.Text = "Chem";
            classTabPage2.UseVisualStyleBackColor = true;
            // 
            // taskAndPriorityUserControl2
            // 
            taskAndPriorityUserControl2.Location = new Point(0, 0);
            taskAndPriorityUserControl2.Name = "taskAndPriorityUserControl2";
            taskAndPriorityUserControl2.Size = new Size(524, 338);
            taskAndPriorityUserControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(taskAndPriorityUserControl3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(536, 332);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "English";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // taskAndPriorityUserControl3
            // 
            taskAndPriorityUserControl3.Location = new Point(0, 0);
            taskAndPriorityUserControl3.Name = "taskAndPriorityUserControl3";
            taskAndPriorityUserControl3.Size = new Size(524, 338);
            taskAndPriorityUserControl3.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(12, 389);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(540, 242);
            outputTextBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menulStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(561, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menulStripMenuItem
            // 
            menulStripMenuItem.Name = "menulStripMenuItem";
            menulStripMenuItem.Size = new Size(46, 20);
            menulStripMenuItem.Text = "Tasks";
            // 
            // ClassPriorityTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 650);
            Controls.Add(outputTextBox);
            Controls.Add(trackerTabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ClassPriorityTrackerForm";
            Text = "Form1";
            trackerTabControl.ResumeLayout(false);
            classTabPage1.ResumeLayout(false);
            classTabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl trackerTabControl;
        private TabPage classTabPage1;
        private TabPage classTabPage2;
        private TabPage tabPage1;
        private PC2A1ControlLibrary.TaskAndPriorityUserControl taskAndPriorityUserControl1;
        private PC2A1ControlLibrary.TaskAndPriorityUserControl taskAndPriorityUserControl2;
        private PC2A1ControlLibrary.TaskAndPriorityUserControl taskAndPriorityUserControl3;
        private TextBox outputTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menulStripMenuItem;
    }
}
