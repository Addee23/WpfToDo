﻿namespace TodoAppWPF

{
    /// <summary>
    /// Hanterar logiken för att lägga till, ta bort och visa todo-items.
    /// </summary>
    public class TodoList

    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public List<string> GetAllTasks()
        {
            return tasks;
        }

        public void ClearAllTasks() //Lägger till en metod som rensar alla tasks från listan
        {
            tasks.Clear();
        }
    }
}
