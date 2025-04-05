using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace PPF_TodoApplication
{
    public partial class ToDoList : Form
    {
        private BindingList<TodoItem> todoList = new BindingList<TodoItem>();
        string path = "AppData/Todo.json";


        public ToDoList()
        {
            InitializeComponent();
            todoList = LoadTodoItemsFromJson("AppData/Todo.json"); // フォーム起動時にJsonファイルを読み込み
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GV_List.DataSource = todoList; // DataGridViewにリストをバインド
            GV_List.AutoGenerateColumns = true;
            GV_List.DataSource = todoList;
        }

        private void CB_Task1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ToDoをtodoListに追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClicked(object sender, EventArgs e)
        {
            TodoItem newItem = new TodoItem
            {
                IsCompleted = false, //追加直後は完了していないのでfalse
                LimitDay = this.TM_LimitDay.Value,
                Todo = this.TB_Todo.Text
            };
            todoList.Add(newItem);
            Console.WriteLine("FilePath: " + path);
            Console.WriteLine("LimitDay: " + newItem.LimitDay);
            Console.WriteLine("Todo: " + newItem.Todo);
            Console.WriteLine("登録をクリック");
        }

        /// <summary>
        /// 選択したToDoを削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (GV_List.CurrentCell != null)    //セルがNull出なければ実行
            {
                int row = GV_List.CurrentCell.RowIndex;
                todoList.RemoveAt(row);
                Console.WriteLine("削除成功!");
            }
            else { 
                Console.WriteLine("削除失敗……");
            }
        }

        /// <summary>
        /// TodoリストをJSONに保存するための準備
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButtonClicked(object sender, EventArgs e)
        {
            SaveTodoItemsToJson(todoList.ToList(), path); //BindingList型をList型に変換して保存
        }

        /// <summary>
        /// TodoリストをJSONに保存
        /// </summary>
        /// <param name="todoItems"></param>
        /// <param name="filePath"></param>
        void SaveTodoItemsToJson(List<TodoItem> todoItems, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // JSONを整形して出力
            try
            {
                string jsonString = JsonSerializer.Serialize(todoItems, options);
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine("ToDoリストを保存しました。");
                Console.WriteLine("FilePath: " + filePath);
                Console.WriteLine("保存内容:");
                Console.WriteLine(File.ReadAllText(filePath)); 
            }
            catch (Exception ex)    //例外処理
            {
                Console.WriteLine($"ToDoリストの保存に失敗しました: {ex.Message}");
                // 必要に応じて、エラーメッセージをユーザーに表示するなどのUI操作を行う
                MessageBox.Show($"保存に失敗しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Jsonファイルが存在するか判定し、存在すれば読み込む
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        BindingList<TodoItem> LoadTodoItemsFromJson(string filePath)
        {
            if (!File.Exists(filePath)) //Jsonファイルが存在しない場合
            {
                return new BindingList<TodoItem>();
            }

            //ファイルが存在した場合
            string jsonString = File.ReadAllText(filePath);
            Console.WriteLine("ファイルが存在した場合：　" + jsonString);
            return JsonSerializer.Deserialize<BindingList<TodoItem>>(jsonString);
        }

    }
}
