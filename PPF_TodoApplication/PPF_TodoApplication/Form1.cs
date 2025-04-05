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
        //基本のデータ管理はtodoDateTableで行う
        //todoListはJson保存用


        private BindingList<TodoItem> todoList = new BindingList<TodoItem>();   //TodoItem型のバウンドリスト
        private DataTable todoDateTable = new DataTable();
        string path = "AppData/Todo.json";  //Jsonファイルの保存先Pathを指定


        public ToDoList()
        {
            InitializeComponent();
            //InitializeDataTable();  //DateTableを初期化
            //GV_List.DataSource = todoDateTable;
            todoList = LoadTodoItemsFromJson("AppData/Todo.json"); // フォーム起動時にJsonファイルをDateTableに読み込み
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GV_List.DataSource = todoList; // DataGridViewにリストをバインド
            GV_List.AutoGenerateColumns = true;
            
        }

        private void CB_Task1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// DataTable（todoDateTable）の初期化
        /// </summary>
        private void InitializeDataTable()
        {
            todoDateTable.Columns.Add("IsCompleted", typeof(bool));
            todoDateTable.Columns.Add("LimitDay", typeof(DateTime));
            todoDateTable.Columns.Add("Todo", typeof(string));
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
            todoList.Add(newItem);  //todoListに追加
            //todoDateTable.Rows.Add(newItem.IsCompleted, newItem.LimitDay, newItem.Todo);    //DateTableに追加

            Console.WriteLine("FilePath: " + path);
            Console.WriteLine("期限: " + newItem.LimitDay);
            Console.WriteLine("やること: " + newItem.Todo);
            Console.WriteLine("登録をクリック");
        }

        /// <summary>
        /// 選択したToDoを削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (GV_List.CurrentCell != null)    //セルがNullでなければ実行
            {
                int row = GV_List.CurrentCell.RowIndex;
                todoList.RemoveAt(row);
                //todoDateTable.Rows.RemoveAt(row);
                Console.WriteLine("削除成功!");
            }
            else { 
                Console.WriteLine("削除失敗");
            }
        }

        /// <summary>
        /// TodoリストをJSONに保存するためのメソッドを呼び出し
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
                Console.WriteLine("ToDoリストを保存!");
                Console.WriteLine("FilePath: " + filePath);
                Console.WriteLine("保存内容:" + todoItems);
                Console.WriteLine(File.ReadAllText(filePath)); 
            }
            catch (Exception ex)    //例外処理
            {
                Console.WriteLine($"ToDoリストの保存に失敗: {ex.Message}");
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
