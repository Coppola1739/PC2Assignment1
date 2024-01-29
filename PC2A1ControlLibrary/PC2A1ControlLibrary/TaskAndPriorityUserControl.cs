using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace PC2A1ControlLibrary
{
    public partial class TaskAndPriorityUserControl : UserControl
    {
        public event EventHandler TaskOrPriorityChanged;
        


        public TaskAndPriorityUserControl()
        {
            InitializeComponent();

        }

        private void onTaskOrPriorityChange()
        {
            if (this.TaskOrPriorityChanged != null)
            {
                this.TaskOrPriorityChanged(this, EventArgs.Empty);
            }
        }

        private void onRadioButtonChanged(object? sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                Debug.WriteLine(radioButton.Name);
            }
            this.onTaskOrPriorityChange();
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lowRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void highRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
