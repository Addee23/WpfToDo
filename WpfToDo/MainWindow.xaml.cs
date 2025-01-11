using System.Windows;

namespace TodoAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TodoList _todoList;
        public MainWindow()
        {

            InitializeComponent();
            _todoList = new TodoList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">sender från mainwindow</param>
        /// <param name="e">event</param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(task))
            {
                _todoList.AddTask(task);
                UpdateTaskList();
                TaskTextBox.Clear();
            }
        }
        /// <summary>
        /// Uppdaterar listan med todo-items.
        /// </summary>
        private void UpdateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var task in _todoList.GetAllTasks())
            {
                TasksListBox.Items.Add(task);
            }
        }

        /// <summary>
        /// Tar bort valt todo-item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListBox.SelectedIndex >= 0)
            {
                _todoList.RemoveTask(TasksListBox.SelectedIndex);
                UpdateTaskList();
            }
        }
    
        private void ClearButton_Click(object sender, RoutedEventArgs e) //Lägger till metod som rensar alla tasks
        {
            _todoList.ClearAllTasks();
            UpdateTaskList();
        }
    }
}