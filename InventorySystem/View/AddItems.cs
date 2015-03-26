using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.View
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        public void initListView()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItemDB adb = new AddItemDB();
            adb.Show();
        }
    }
}
