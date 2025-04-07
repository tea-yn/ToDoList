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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace PPF_TodoApplication
{
    public partial class ToDoList : Form
    {
        private BindingList<TodoItem> todoList = new BindingList<TodoItem>();   //TodoItem型のバウンドリスト
        string path = "AppData/Todo.json";  //Jsonファイルの保存先Pathを指定


        public ToDoList()
        {
            InitializeComponent();
            SetupListView();
            todoList = LoadTodoItemsFromJson("AppData/Todo.json"); // フォーム起動時にJsonファイルをtodoListに読み込み
            UpdateListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void CB_Task1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// TodoListViewの初期設定
        /// </summary>
        private void SetupListView()
        {
            TodoListView.View = View.Details;   //表形式
            TodoListView.FullRowSelect = true;      // 行全体を選択対象にする
            TodoListView.CheckBoxes = true; //チェックボックスを表示する

            TodoListView.BackColor = Color.Ivory;

            TodoListView.Columns.Add("完了",-2,HorizontalAlignment.Center);
            TodoListView.Columns.Add("期限", 150, HorizontalAlignment.Center);
            TodoListView.Columns.Add("すること", 300, HorizontalAlignment.Center);
           
            TodoListView.ItemCheck += CheckListViewItem;
        }

        /// <summary>
        /// todoListから取得してTodoListViewの内容を更新
        /// </summary>
        private void UpdateListView()
        {
            TodoListView.Items.Clear(); //初期化しておく
            foreach (var item in todoList)
            {
                var listItem = new ListViewItem("");
                listItem.Checked = item.IsCompleted;
                listItem.SubItems.Add(item.LimitDay.ToShortDateString());
                listItem.SubItems.Add(item.Todo);

                
                if (item.IsCompleted)
                {
                    //ここで取り消し線の処理を行う
                    TodoListView.ForeColor = Color.LightGray;
                    TodoListView.Font = new Font(TodoListView.Font, FontStyle.Strikeout);
                }else
                {
                    TodoListView.ForeColor = Color.Black;
                    TodoListView.Font = new Font(TodoListView.Font, FontStyle.Regular);
                }

                //ListViewにTodoListの内容を反映
                TodoListView.Items.Add(listItem);
            }
            
        }

        /// <summary>
        /// ToDoをtodoListに追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("登録をクリック");

            TodoItem newItem = new TodoItem
            {
                IsCompleted = false, //追加直後は完了していないのでfalse
                LimitDay = this.TM_LimitDay.Value,
                Todo = this.TB_Todo.Text
            };
            todoList.Add(newItem);  //todoListに追加
            UpdateListView();

            Console.WriteLine("FilePath: " + path);
            Console.WriteLine("期限: " + newItem.LimitDay);
            Console.WriteLine("やること: " + newItem.Todo);
            Console.WriteLine("完了: " + newItem.IsCompleted);
        }

        /// <summary>
        /// 選択したToDoを削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            if (TodoListView.SelectedIndices.Count > 0)    //選択したセルが1以上であれば
            {
                int num = TodoListView.SelectedIndices[0];
                todoList.RemoveAt(num);
                UpdateListView();
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

        /// <summary>
        /// リストのチェックボックスの状態を管理するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckListViewItem(object sender, ItemCheckEventArgs e)
        {
            // クリックしたアイテムのインデックスを取得
            int index = e.Index;
            bool isChecked = e.NewValue == CheckState.Checked;

            // todoListの該当アイテムを更新
            todoList[index].IsCompleted = isChecked;

            //ここで取り消し線の処理を行う
            /*
            var listViewItem = TodoListView.Items[index];

            Font currentFont = listViewItem.SubItems[2].Font; 
            Font newFont = new Font(currentFont, isChecked ? FontStyle.Strikeout : FontStyle.Regular);
            listViewItem.SubItems[2].Font = newFont;
            */
            if (isChecked)  //完了状態の場合
            { 
                TodoListView.Items[index].ForeColor = Color.LightGray;
                TodoListView.Items[index].Font = new Font(TodoListView.Font, FontStyle.Strikeout);
            }
            else //未完了の場合
            {
                TodoListView.Items[index].ForeColor = Color.Black;
                TodoListView.Items[index].Font = new Font(TodoListView.Font, FontStyle.Regular);
            }

            Console.WriteLine("選択した列番号：　" + index);
            Console.WriteLine("完了：　" + isChecked);
        }
    }
}
