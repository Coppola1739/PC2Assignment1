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
            this.TaskOrPriorityChanged?.Invoke(this, EventArgs.Empty);
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

        private void onContextMenuCheckAll(object? sender, EventArgs e)
        {
            taskDataGridView.EndEdit();

            for (int i = 0; i < taskDataGridView.Rows.Count - 1; i++)
            {
                bool isChecked = Convert.ToBoolean(taskDataGridView.Rows[i].Cells["DoneColumn"].Value);
                if (!isChecked)
                {
                    taskDataGridView.Rows[i].Cells["DoneColumn"].Value = true;
                }
            }
            this.onTaskOrPriorityChange();
        }


        private void onContextMenuUncheckAll(object? sender, EventArgs e)
        {
            taskDataGridView.EndEdit();

            for (int i = 0; i < taskDataGridView.Rows.Count - 1; i++)
            {
                bool isChecked = Convert.ToBoolean(taskDataGridView.Rows[i].Cells["DoneColumn"].Value);
                if (isChecked)
                {
                    taskDataGridView.Rows[i].Cells["DoneColumn"].Value = false;
                }
            }
            this.onTaskOrPriorityChange();
        }
    }
}
