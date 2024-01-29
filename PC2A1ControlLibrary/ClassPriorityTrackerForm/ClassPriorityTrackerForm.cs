using System.Threading.Tasks.Sources;
using ClassPriorityTrackerForm.Utilities;

namespace ClassPriorityTrackerForm
{
    public partial class ClassPriorityTrackerForm : Form
    {
        public ClassPriorityTrackerForm()
        {
            InitializeComponent();
            taskAndPriorityUserControl1.TaskOrPriorityChanged += onTaskOrPriorityChanged;
            taskAndPriorityUserControl2.TaskOrPriorityChanged += onTaskOrPriorityChanged;
            taskAndPriorityUserControl3.TaskOrPriorityChanged += onTaskOrPriorityChanged;
        }

        private void onTaskOrPriorityChanged(object? sender, EventArgs e)
        {
            var outputFormatter = new OutputTextFormatter();
            
            outputTextBox.Text = outputFormatter.OutputText();
        }

        private void updateTextArea()
        {

        }
    }
}
