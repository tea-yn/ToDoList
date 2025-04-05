using System;
using System.Data;
using System.IO;
using System.Text.Json;


namespace PPF_TodoApplication
{
    /// <summary>
    /// TodoItemModel
    /// </summary>
    public class TodoItem
    {
        public string Todo {  get; set; }
        public DateTime LimitDay { get; set; }
        public bool IsCompleted { get; set; }
    }
}
