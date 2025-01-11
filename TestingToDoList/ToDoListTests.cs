using TodoAppWPF;
namespace TestingToDoList
{
    public class ToDoListTests
    {
        private TodoList _toDoList;
        public ToDoListTests()
        {
            _toDoList = new TodoList();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _toDoList.AddTask(task);
            var tasks = _toDoList.GetAllTasks();
            Assert.Contains(task, tasks);
        }

        [Fact]

        public void RemoveTask_ShouldRemoveTaskToList()
        {
            var task = "Task to remove";
            _toDoList.AddTask(task);
            _toDoList.RemoveTask(0);
            var tasks = _toDoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]

        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "Valid Task";
            _toDoList.AddTask(task);
            _toDoList.RemoveTask(9);//Invalid index
            var tasks = _toDoList.GetAllTasks();
            Assert.Single(tasks); //Den ursprungliga uppgiften ska fortfarande finnas kvar
        }
        [Fact]
        public void ClearAllTasks_ShouldRemoveAllTasks()
        {
            //Arrange
            _toDoList.AddTask("Task 1");
            _toDoList.AddTask("Task 2");
            _toDoList.AddTask("Task 3");

            //Act
            _toDoList.ClearAllTasks();
            var tasks = _toDoList.GetAllTasks();

            //Assert
            Assert.Empty(tasks);
        }
    }
}


    

