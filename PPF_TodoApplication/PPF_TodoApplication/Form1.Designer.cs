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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GV_List = new System.Windows.Forms.DataGridView();
            this.完了DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.期限DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.やることDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TodolistView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_List
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("游ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            this.GV_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GV_List.AutoGenerateColumns = false;
            this.GV_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_List.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GV_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GV_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.完了DataGridViewCheckBoxColumn,
            this.期限DataGridViewTextBoxColumn,
            this.やることDataGridViewTextBoxColumn});
            this.GV_List.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.GV_List.DataSource = this.todoDateTableBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV_List.DefaultCellStyle = dataGridViewCellStyle3;
            this.GV_List.GridColor = System.Drawing.Color.WhiteSmoke;
            this.GV_List.Location = new System.Drawing.Point(53, 38);
            this.GV_List.Margin = new System.Windows.Forms.Padding(4);
            this.GV_List.Name = "GV_List";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GV_List.RowHeadersVisible = false;
            this.GV_List.RowHeadersWidth = 51;
            this.GV_List.RowTemplate.Height = 21;
            this.GV_List.Size = new System.Drawing.Size(667, 500);
            this.GV_List.TabIndex = 1;
            // 
            // 完了DataGridViewCheckBoxColumn
            // 
            this.完了DataGridViewCheckBoxColumn.DataPropertyName = "完了";
            this.完了DataGridViewCheckBoxColumn.HeaderText = "完了";
            this.完了DataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.完了DataGridViewCheckBoxColumn.Name = "完了DataGridViewCheckBoxColumn";
            // 
            // 期限DataGridViewTextBoxColumn
            // 
            this.期限DataGridViewTextBoxColumn.DataPropertyName = "期限";
            this.期限DataGridViewTextBoxColumn.HeaderText = "期限";
            this.期限DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.期限DataGridViewTextBoxColumn.Name = "期限DataGridViewTextBoxColumn";
            // 
            // やることDataGridViewTextBoxColumn
            // 
            this.やることDataGridViewTextBoxColumn.DataPropertyName = "やること";
            this.やることDataGridViewTextBoxColumn.HeaderText = "やること";
            this.やることDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.やることDataGridViewTextBoxColumn.Name = "やることDataGridViewTextBoxColumn";
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
            // TodolistView
            // 
            this.TodolistView.HideSelection = false;
            this.TodolistView.Location = new System.Drawing.Point(279, 140);
            this.TodolistView.Name = "TodolistView";
            this.TodolistView.Size = new System.Drawing.Size(441, 310);
            this.TodolistView.TabIndex = 10;
            this.TodolistView.UseCompatibleStateImageBehavior = false;
            this.TodolistView.View = System.Windows.Forms.View.Details;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 576);
            this.Controls.Add(this.TodolistView);
            this.Controls.Add(this.TM_LimitDay);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.TB_Todo);
            this.Controls.Add(this.LB_Todo);
            this.Controls.Add(this.LB_Limit);
            this.Controls.Add(this.GV_List);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoList";
            this.Text = "ToDoリスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoDateSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GV_List;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn 完了DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 期限DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn やることDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView TodolistView;
    }
}

