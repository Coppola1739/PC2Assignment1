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
    }
}
