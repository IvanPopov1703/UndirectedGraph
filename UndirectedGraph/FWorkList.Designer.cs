namespace UndirectedGraph
{
    partial class FWorkList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.cb_ConnectPeaksNode2 = new System.Windows.Forms.ComboBox();
            this.cb_ConnectPeaksNode1 = new System.Windows.Forms.ComboBox();
            this.bt_ConnectPeaks = new System.Windows.Forms.Button();
            this.tb_NameDelNode = new System.Windows.Forms.TextBox();
            this.bt_DelNode = new System.Windows.Forms.Button();
            this.tb_NameVertices = new System.Windows.Forms.TextBox();
            this.bt_AddVertices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(668, 143);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(209, 22);
            this.tb_weight.TabIndex = 15;
            // 
            // cb_ConnectPeaksNode2
            // 
            this.cb_ConnectPeaksNode2.FormattingEnabled = true;
            this.cb_ConnectPeaksNode2.Location = new System.Drawing.Point(443, 143);
            this.cb_ConnectPeaksNode2.Name = "cb_ConnectPeaksNode2";
            this.cb_ConnectPeaksNode2.Size = new System.Drawing.Size(209, 24);
            this.cb_ConnectPeaksNode2.TabIndex = 14;
            // 
            // cb_ConnectPeaksNode1
            // 
            this.cb_ConnectPeaksNode1.FormattingEnabled = true;
            this.cb_ConnectPeaksNode1.Location = new System.Drawing.Point(228, 143);
            this.cb_ConnectPeaksNode1.Name = "cb_ConnectPeaksNode1";
            this.cb_ConnectPeaksNode1.Size = new System.Drawing.Size(209, 24);
            this.cb_ConnectPeaksNode1.TabIndex = 13;
            // 
            // bt_ConnectPeaks
            // 
            this.bt_ConnectPeaks.Location = new System.Drawing.Point(12, 133);
            this.bt_ConnectPeaks.Name = "bt_ConnectPeaks";
            this.bt_ConnectPeaks.Size = new System.Drawing.Size(198, 42);
            this.bt_ConnectPeaks.TabIndex = 12;
            this.bt_ConnectPeaks.Text = "Связать вершины";
            this.bt_ConnectPeaks.UseVisualStyleBackColor = true;
            this.bt_ConnectPeaks.Click += new System.EventHandler(this.bt_ConnectPeaks_Click);
            // 
            // tb_NameDelNode
            // 
            this.tb_NameDelNode.Location = new System.Drawing.Point(228, 82);
            this.tb_NameDelNode.Name = "tb_NameDelNode";
            this.tb_NameDelNode.Size = new System.Drawing.Size(209, 22);
            this.tb_NameDelNode.TabIndex = 11;
            // 
            // bt_DelNode
            // 
            this.bt_DelNode.Location = new System.Drawing.Point(12, 72);
            this.bt_DelNode.Name = "bt_DelNode";
            this.bt_DelNode.Size = new System.Drawing.Size(198, 42);
            this.bt_DelNode.TabIndex = 10;
            this.bt_DelNode.Text = "Удалить вершину";
            this.bt_DelNode.UseVisualStyleBackColor = true;
            this.bt_DelNode.Click += new System.EventHandler(this.bt_DelNode_Click);
            // 
            // tb_NameVertices
            // 
            this.tb_NameVertices.Location = new System.Drawing.Point(228, 22);
            this.tb_NameVertices.Name = "tb_NameVertices";
            this.tb_NameVertices.Size = new System.Drawing.Size(209, 22);
            this.tb_NameVertices.TabIndex = 9;
            // 
            // bt_AddVertices
            // 
            this.bt_AddVertices.Location = new System.Drawing.Point(12, 12);
            this.bt_AddVertices.Name = "bt_AddVertices";
            this.bt_AddVertices.Size = new System.Drawing.Size(198, 42);
            this.bt_AddVertices.TabIndex = 8;
            this.bt_AddVertices.Text = "Добавить вершину";
            this.bt_AddVertices.UseVisualStyleBackColor = true;
            this.bt_AddVertices.Click += new System.EventHandler(this.bt_AddVertices_Click);
            // 
            // FWorkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.cb_ConnectPeaksNode2);
            this.Controls.Add(this.cb_ConnectPeaksNode1);
            this.Controls.Add(this.bt_ConnectPeaks);
            this.Controls.Add(this.tb_NameDelNode);
            this.Controls.Add(this.bt_DelNode);
            this.Controls.Add(this.tb_NameVertices);
            this.Controls.Add(this.bt_AddVertices);
            this.Name = "FWorkList";
            this.Text = "Форма для работы со списком";
            this.Load += new System.EventHandler(this.FWorkList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.ComboBox cb_ConnectPeaksNode2;
        private System.Windows.Forms.ComboBox cb_ConnectPeaksNode1;
        private System.Windows.Forms.Button bt_ConnectPeaks;
        private System.Windows.Forms.TextBox tb_NameDelNode;
        private System.Windows.Forms.Button bt_DelNode;
        private System.Windows.Forms.TextBox tb_NameVertices;
        private System.Windows.Forms.Button bt_AddVertices;
    }
}