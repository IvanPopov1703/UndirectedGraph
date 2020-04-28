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
    public partial class FMain : Form
    {
        const int countVertices = 4;
        string[] masStr = new string[countVertices] { "СПБ", "Москва", "Воронеж", "Уфа" };
        //Объект формы добавления новой вершины
        FAddVertices fAddVertices = new FAddVertices();
        //Реализация на основе массива
        ArrayGraph<string, int> arrayGr = new ArrayGraph<string, int>();
        //Массив с вершинами
        string[] arrVert;
        //Массив с ребрами
        int[,] arrEges;
        //Массив для с вершинами для рисования
        CellDraw[] arrCellDraws; 

        public FMain()
        {
            InitializeComponent();
            //HelpDrawGraph();
        }

        private void FUndirectedGraph_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < countVertices; i++)
                cb_ConnectPeaksNode1.Items.Add(masStr[i]);

            for (int i = 0; i < countVertices; i++)
                cb_ConnectPeaksNode2.Items.Add(masStr[i]);
        }

        private void bt_AddVertices_Click(object sender, EventArgs e)
        {
            /*fAddVertices.ShowDialog();
            if (fAddVertices.NameVertices != "")
            {
                if (arrayGr.AddNode(fAddVertices.NameVertices))
                {
                    MessageBox.Show(this, "Неудалось добавить запись!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Запись успешно добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }*/
            for (int i = 0; i < countVertices; i++)
            {
                if (arrayGr.AddNode(masStr[i])) ;
                //MessageBox.Show(this, "Вершина добавлена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show(this, "Не удалось добавить вершину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_DelNode_Click(object sender, EventArgs e)
        {
            if (arrayGr.Remove(tb_NameDelNode.Text))
                MessageBox.Show(this, "Вершина удалена!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(this, "Не удалось удалить вершину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_ConnectPeaks_Click(object sender, EventArgs e)
        {
            if (arrayGr.AddLink(cb_ConnectPeaksNode1.Text, cb_ConnectPeaksNode2.Text, Convert.ToInt32(tb_weight.Text)))
                MessageBox.Show(this, "Ребро добавлено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(this, "Не удалось добавить ребро!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_workList_Click(object sender, EventArgs e)
        {
            this.Hide();
            FWorkList fWorkList = new FWorkList();
            fWorkList.Show();
        }

        //Вспомогательная функция для рисования дуг
        private void HelpDrawGraphEdges(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);
            arrEges = arrayGr.GetValueFromArrEdges();
            SolidBrush br = new SolidBrush(Color.Black);
            Font myFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            for (int i = 0; i < arrCellDraws.Length; i++)
            {
                for (int j = 0; j < arrCellDraws.Length; j++)
                {
                    if (arrEges[i, j] != 0)
                    {
                        graphics.DrawLine(pen, arrCellDraws[i].CoordX, arrCellDraws[i].CoordY, arrCellDraws[j].CoordX, arrCellDraws[j].CoordY);
                        graphics.DrawString(arrCellDraws[i].Name, myFont, br, arrCellDraws[i].CoordX, arrCellDraws[i].CoordY + 50);
                        arrEges[i, j] = 0;
                        arrEges[j, i] = 0;
                    }
                }
            }
        }

        //Вспомогательная функция для рисования вершин
        private void HelpDrawGraphVertices()
        {
            Bitmap bmp = new Bitmap(pb_graph.Width, pb_graph.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            SolidBrush br = new SolidBrush(Color.Black);
            Font myFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            for (int i = 0; i < arrCellDraws.Length; i++)
            {
                graphics.DrawRectangle(pen, arrCellDraws[i].CoordX, arrCellDraws[i].CoordY, 10, 10);
                graphics.DrawString(arrCellDraws[i].Name, myFont, br, arrCellDraws[i].CoordX, arrCellDraws[i].CoordY - 20);

            }

            HelpDrawGraphEdges(graphics);

            pb_graph.Image = bmp;
        }

        private void bt_Draw_graph_Click(object sender, EventArgs e)
        {
            int x = 1, y = 1;
            arrCellDraws = new CellDraw[arrayGr.Count];
            arrVert = arrayGr.GetValueFromArrVertices();
            int posX = pb_graph.Width / arrayGr.Count;
            int posY = pb_graph.Height / arrayGr.Count;
            for (int i = 0; i < arrayGr.Count; i++)
            {
                arrCellDraws[i] = new CellDraw(arrVert[i], posX * x, posY * y);
                x++;
                if ((i + 1) == (arrayGr.Count / 2))
                {
                    x = 1;
                    y++;
                }
            }
            HelpDrawGraphVertices();
        }
    }
}