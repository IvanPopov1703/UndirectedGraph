using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndirectedGraph
{
    public partial class FWorkList : Form
    {
        //true - если массив заполнени и добавление новой вершины невозможно
        public bool arrFull = false;
        const int countVertices = 4;
        string[] masStr = new string[countVertices] { "СПБ", "Москва", "Воронеж", "Уфа" };
        LinkedGraph<string, int> listGr = new LinkedGraph<string, int>("", 0);
        //Массив с вершинами
        string[] arrValueVertices = new string[5];

        public FWorkList()
        {
            InitializeComponent();
        }

        private void bt_AddVertices_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countVertices; i++)
            {
                if (listGr.AddNode(masStr[i]))
                    MessageBox.Show(this, "Вершина добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show(this, "Не удалось добавить вершину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_ConnectPeaks_Click(object sender, EventArgs e)
        {
            if (listGr.AddLink(cb_ConnectPeaksNode1.Text, cb_ConnectPeaksNode2.Text, Convert.ToInt32(tb_weight.Text)))
                MessageBox.Show(this, "Вершина добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(this, "Не удалось добавить вершину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FWorkList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < countVertices; i++)
                cb_ConnectPeaksNode1.Items.Add(masStr[i]);

            for (int i = 0; i < countVertices; i++)
                cb_ConnectPeaksNode2.Items.Add(masStr[i]);
        }

        private void bt_DelNode_Click(object sender, EventArgs e)
        {
            listGr.Remove(tb_NameDelNode.Text);
        }
    }
}
