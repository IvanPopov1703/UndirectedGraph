namespace UndirectedGraph
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_AddVertices = new System.Windows.Forms.Button();
            this.tb_NameVertices = new System.Windows.Forms.TextBox();
            this.bt_DelNode = new System.Windows.Forms.Button();
            this.tb_NameDelNode = new System.Windows.Forms.TextBox();
            this.bt_ConnectPeaks = new System.Windows.Forms.Button();
            this.cb_ConnectPeaksNode1 = new System.Windows.Forms.ComboBox();
            this.cb_ConnectPeaksNode2 = new System.Windows.Forms.ComboBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.bt_workList = new System.Windows.Forms.Button();
            this.rb_array = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_list = new System.Windows.Forms.RadioButton();
            this.panelRepresentation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_check = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_bypass_width = new System.Windows.Forms.Button();
            this.bt_bypass_depth = new System.Windows.Forms.Button();
            this.bt_Search_shortest_path = new System.Windows.Forms.Button();
            this.bt_Draw_graph = new System.Windows.Forms.Button();
            this.pb_graph = new System.Windows.Forms.PictureBox();
            this.panelRepresentation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AddVertices
            // 
            this.bt_AddVertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddVertices.Location = new System.Drawing.Point(6, 3);
            this.bt_AddVertices.Name = "bt_AddVertices";
            this.bt_AddVertices.Size = new System.Drawing.Size(254, 32);
            this.bt_AddVertices.TabIndex = 0;
            this.bt_AddVertices.Text = "Добавить вершину";
            this.bt_AddVertices.UseVisualStyleBackColor = true;
            this.bt_AddVertices.Click += new System.EventHandler(this.bt_AddVertices_Click);
            // 
            // tb_NameVertices
            // 
            this.tb_NameVertices.Location = new System.Drawing.Point(7, 465);
            this.tb_NameVertices.Name = "tb_NameVertices";
            this.tb_NameVertices.Size = new System.Drawing.Size(209, 22);
            this.tb_NameVertices.TabIndex = 1;
            // 
            // bt_DelNode
            // 
            this.bt_DelNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DelNode.Location = new System.Drawing.Point(4, 41);
            this.bt_DelNode.Name = "bt_DelNode";
            this.bt_DelNode.Size = new System.Drawing.Size(254, 31);
            this.bt_DelNode.TabIndex = 2;
            this.bt_DelNode.Text = "Удалить вершину";
            this.bt_DelNode.UseVisualStyleBackColor = true;
            this.bt_DelNode.Click += new System.EventHandler(this.bt_DelNode_Click);
            // 
            // tb_NameDelNode
            // 
            this.tb_NameDelNode.Location = new System.Drawing.Point(7, 493);
            this.tb_NameDelNode.Name = "tb_NameDelNode";
            this.tb_NameDelNode.Size = new System.Drawing.Size(209, 22);
            this.tb_NameDelNode.TabIndex = 3;
            // 
            // bt_ConnectPeaks
            // 
            this.bt_ConnectPeaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_ConnectPeaks.Location = new System.Drawing.Point(6, 78);
            this.bt_ConnectPeaks.Name = "bt_ConnectPeaks";
            this.bt_ConnectPeaks.Size = new System.Drawing.Size(254, 31);
            this.bt_ConnectPeaks.TabIndex = 4;
            this.bt_ConnectPeaks.Text = "Соединить вершины";
            this.bt_ConnectPeaks.UseVisualStyleBackColor = true;
            this.bt_ConnectPeaks.Click += new System.EventHandler(this.bt_ConnectPeaks_Click);
            // 
            // cb_ConnectPeaksNode1
            // 
            this.cb_ConnectPeaksNode1.FormattingEnabled = true;
            this.cb_ConnectPeaksNode1.Location = new System.Drawing.Point(7, 525);
            this.cb_ConnectPeaksNode1.Name = "cb_ConnectPeaksNode1";
            this.cb_ConnectPeaksNode1.Size = new System.Drawing.Size(209, 24);
            this.cb_ConnectPeaksNode1.TabIndex = 5;
            // 
            // cb_ConnectPeaksNode2
            // 
            this.cb_ConnectPeaksNode2.FormattingEnabled = true;
            this.cb_ConnectPeaksNode2.Location = new System.Drawing.Point(7, 555);
            this.cb_ConnectPeaksNode2.Name = "cb_ConnectPeaksNode2";
            this.cb_ConnectPeaksNode2.Size = new System.Drawing.Size(209, 24);
            this.cb_ConnectPeaksNode2.TabIndex = 6;
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(7, 585);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(209, 22);
            this.tb_weight.TabIndex = 7;
            // 
            // bt_workList
            // 
            this.bt_workList.Location = new System.Drawing.Point(7, 613);
            this.bt_workList.Name = "bt_workList";
            this.bt_workList.Size = new System.Drawing.Size(213, 47);
            this.bt_workList.TabIndex = 8;
            this.bt_workList.Text = "Работа со списком";
            this.bt_workList.UseVisualStyleBackColor = true;
            this.bt_workList.Click += new System.EventHandler(this.bt_workList_Click);
            // 
            // rb_array
            // 
            this.rb_array.AutoSize = true;
            this.rb_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_array.Location = new System.Drawing.Point(16, 43);
            this.rb_array.Name = "rb_array";
            this.rb_array.Size = new System.Drawing.Size(204, 28);
            this.rb_array.TabIndex = 9;
            this.rb_array.TabStop = true;
            this.rb_array.Text = "На основе массива";
            this.rb_array.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выберите представление";
            // 
            // rb_list
            // 
            this.rb_list.AutoSize = true;
            this.rb_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_list.Location = new System.Drawing.Point(16, 77);
            this.rb_list.Name = "rb_list";
            this.rb_list.Size = new System.Drawing.Size(190, 28);
            this.rb_list.TabIndex = 11;
            this.rb_list.TabStop = true;
            this.rb_list.Text = "На основе списка";
            this.rb_list.UseVisualStyleBackColor = true;
            // 
            // panelRepresentation
            // 
            this.panelRepresentation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRepresentation.Controls.Add(this.rb_array);
            this.panelRepresentation.Controls.Add(this.rb_list);
            this.panelRepresentation.Controls.Add(this.label1);
            this.panelRepresentation.Location = new System.Drawing.Point(2, 2);
            this.panelRepresentation.Name = "panelRepresentation";
            this.panelRepresentation.Size = new System.Drawing.Size(265, 113);
            this.panelRepresentation.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.bt_check);
            this.panel1.Controls.Add(this.bt_AddVertices);
            this.panel1.Controls.Add(this.bt_DelNode);
            this.panel1.Controls.Add(this.bt_ConnectPeaks);
            this.panel1.Location = new System.Drawing.Point(2, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 216);
            this.panel1.TabIndex = 13;
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_clear.Location = new System.Drawing.Point(6, 177);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(254, 32);
            this.bt_clear.TabIndex = 6;
            this.bt_clear.Text = "Удалить граф";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_check
            // 
            this.bt_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_check.Location = new System.Drawing.Point(6, 115);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(254, 56);
            this.bt_check.TabIndex = 5;
            this.bt_check.Text = "Проверить наличие вершины";
            this.bt_check.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_bypass_width);
            this.panel2.Controls.Add(this.bt_bypass_depth);
            this.panel2.Controls.Add(this.bt_Search_shortest_path);
            this.panel2.Location = new System.Drawing.Point(2, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 117);
            this.panel2.TabIndex = 14;
            // 
            // bt_bypass_width
            // 
            this.bt_bypass_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_bypass_width.Location = new System.Drawing.Point(3, 3);
            this.bt_bypass_width.Name = "bt_bypass_width";
            this.bt_bypass_width.Size = new System.Drawing.Size(254, 32);
            this.bt_bypass_width.TabIndex = 0;
            this.bt_bypass_width.Text = "Обход графа в ширину";
            this.bt_bypass_width.UseVisualStyleBackColor = true;
            // 
            // bt_bypass_depth
            // 
            this.bt_bypass_depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_bypass_depth.Location = new System.Drawing.Point(4, 41);
            this.bt_bypass_depth.Name = "bt_bypass_depth";
            this.bt_bypass_depth.Size = new System.Drawing.Size(254, 31);
            this.bt_bypass_depth.TabIndex = 2;
            this.bt_bypass_depth.Text = "Обход графа в глучину";
            this.bt_bypass_depth.UseVisualStyleBackColor = true;
            // 
            // bt_Search_shortest_path
            // 
            this.bt_Search_shortest_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Search_shortest_path.Location = new System.Drawing.Point(6, 78);
            this.bt_Search_shortest_path.Name = "bt_Search_shortest_path";
            this.bt_Search_shortest_path.Size = new System.Drawing.Size(254, 31);
            this.bt_Search_shortest_path.TabIndex = 4;
            this.bt_Search_shortest_path.Text = "Поиск кратчайшего пути";
            this.bt_Search_shortest_path.UseVisualStyleBackColor = true;
            // 
            // bt_Draw_graph
            // 
            this.bt_Draw_graph.Location = new System.Drawing.Point(483, 482);
            this.bt_Draw_graph.Name = "bt_Draw_graph";
            this.bt_Draw_graph.Size = new System.Drawing.Size(160, 33);
            this.bt_Draw_graph.TabIndex = 16;
            this.bt_Draw_graph.Text = "Нарисовать граф";
            this.bt_Draw_graph.UseVisualStyleBackColor = true;
            this.bt_Draw_graph.Click += new System.EventHandler(this.bt_Draw_graph_Click);
            // 
            // pb_graph
            // 
            this.pb_graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_graph.Location = new System.Drawing.Point(273, 2);
            this.pb_graph.Name = "pb_graph";
            this.pb_graph.Size = new System.Drawing.Size(627, 458);
            this.pb_graph.TabIndex = 17;
            this.pb_graph.TabStop = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 650);
            this.Controls.Add(this.pb_graph);
            this.Controls.Add(this.bt_Draw_graph);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRepresentation);
            this.Controls.Add(this.bt_workList);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.cb_ConnectPeaksNode2);
            this.Controls.Add(this.cb_ConnectPeaksNode1);
            this.Controls.Add(this.tb_NameDelNode);
            this.Controls.Add(this.tb_NameVertices);
            this.Name = "FMain";
            this.Text = "Неориентированный граф";
            this.Load += new System.EventHandler(this.FUndirectedGraph_Load);
            this.panelRepresentation.ResumeLayout(false);
            this.panelRepresentation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AddVertices;
        private System.Windows.Forms.TextBox tb_NameVertices;
        private System.Windows.Forms.Button bt_DelNode;
        private System.Windows.Forms.TextBox tb_NameDelNode;
        private System.Windows.Forms.Button bt_ConnectPeaks;
        private System.Windows.Forms.ComboBox cb_ConnectPeaksNode1;
        private System.Windows.Forms.ComboBox cb_ConnectPeaksNode2;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.Button bt_workList;
        private System.Windows.Forms.RadioButton rb_array;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_list;
        private System.Windows.Forms.Panel panelRepresentation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_bypass_width;
        private System.Windows.Forms.Button bt_bypass_depth;
        private System.Windows.Forms.Button bt_Search_shortest_path;
        private System.Windows.Forms.Button bt_Draw_graph;
        private System.Windows.Forms.PictureBox pb_graph;
    }
}

