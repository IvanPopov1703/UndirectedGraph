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
    public partial class FAddVertices : Form
    {

        public String NameVertices { get; private set; }

        public FAddVertices()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            NameVertices = "";
            tb_name.Text = "";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            NameVertices = tb_name.Text;
            Close();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Clear();
            Close();
        }

        private void FAddVertices_Load(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
