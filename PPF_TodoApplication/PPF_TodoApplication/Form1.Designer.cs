namespace PPF_TodoApplication
{
    partial class ToDoList
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.todoDateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoDateSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoDateSet = new PPF_TodoApplication.TodoDateSet();
            this.LB_Limit = new System.Windows.Forms.Label();
            this.TB_Todo = new System.Windows.Forms.TextBox();
            this.LB_Todo = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.TM_LimitDay = new System.Windows.Forms.DateTimePicker();
            this.TodoListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSet)).BeginInit();
            this.SuspendLayout();
            // 
            // todoDateTableBindingSource
            // 
            this.todoDateTableBindingSource.DataMember = "TodoDateTable";
            this.todoDateTableBindingSource.DataSource = this.todoDateSetBindingSource;
            // 
            // todoDateSetBindingSource
            // 
            this.todoDateSetBindingSource.DataSource = this.todoDateSet;
            this.todoDateSetBindingSource.Position = 0;
            // 
            // todoDateSet
            // 
            this.todoDateSet.DataSetName = "TodoDateSet";
            this.todoDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LB_Limit
            // 
            this.LB_Limit.AutoSize = true;
            this.LB_Limit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Limit.Location = new System.Drawing.Point(763, 52);
            this.LB_Limit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Limit.Name = "LB_Limit";
            this.LB_Limit.Size = new System.Drawing.Size(49, 20);
            this.LB_Limit.TabIndex = 2;
            this.LB_Limit.Text = "期限";
            this.LB_Limit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Todo
            // 
            this.TB_Todo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_Todo.Location = new System.Drawing.Point(767, 164);
            this.TB_Todo.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Todo.Name = "TB_Todo";
            this.TB_Todo.Size = new System.Drawing.Size(223, 27);
            this.TB_Todo.TabIndex = 5;
            // 
            // LB_Todo
            // 
            this.LB_Todo.AutoSize = true;
            this.LB_Todo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Todo.Location = new System.Drawing.Point(763, 140);
            this.LB_Todo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Todo.Name = "LB_Todo";
            this.LB_Todo.Size = new System.Drawing.Size(68, 20);
            this.LB_Todo.TabIndex = 4;
            this.LB_Todo.Text = "やること";
            this.LB_Todo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_Add
            // 
            this.BT_Add.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Add.Location = new System.Drawing.Point(767, 406);
            this.BT_Add.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(100, 38);
            this.BT_Add.TabIndex = 6;
            this.BT_Add.Text = "登録";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Delete.Location = new System.Drawing.Point(891, 406);
            this.BT_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(100, 38);
            this.BT_Delete.TabIndex = 7;
            this.BT_Delete.Text = "削除";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.DeleteButtonClicked);
            // 
            // BT_Save
            // 
            this.BT_Save.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(767, 469);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(224, 56);
            this.BT_Save.TabIndex = 8;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // TM_LimitDay
            // 
            this.TM_LimitDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TM_LimitDay.Location = new System.Drawing.Point(763, 76);
            this.TM_LimitDay.Margin = new System.Windows.Forms.Padding(4);
            this.TM_LimitDay.Name = "TM_LimitDay";
            this.TM_LimitDay.Size = new System.Drawing.Size(227, 22);
            this.TM_LimitDay.TabIndex = 9;
            // 
            // TodoListView
            // 
            this.TodoListView.HideSelection = false;
            this.TodoListView.Location = new System.Drawing.Point(34, 37);
            this.TodoListView.Name = "TodoListView";
            this.TodoListView.Size = new System.Drawing.Size(676, 488);
            this.TodoListView.TabIndex = 10;
            this.TodoListView.UseCompatibleStateImageBehavior = false;
            this.TodoListView.View = System.Windows.Forms.View.Details;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 576);
            this.Controls.Add(this.TodoListView);
            this.Controls.Add(this.TM_LimitDay);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_Todo);
            this.Controls.Add(this.LB_Todo);
            this.Controls.Add(this.LB_Limit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoList";
            this.Text = "ToDoリスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoDateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_Limit;
        private System.Windows.Forms.TextBox TB_Todo;
        private System.Windows.Forms.Label LB_Todo;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.DateTimePicker TM_LimitDay;
        private System.Windows.Forms.BindingSource todoDateSetBindingSource;
        private TodoDateSet todoDateSet;
        private System.Windows.Forms.BindingSource todoDateTableBindingSource;
        private System.Windows.Forms.ListView TodoListView;
    }
}

