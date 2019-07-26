using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnMakeOrder_Click(object sender, EventArgs e)
        {
            Order ord = new Order(); this.Hide();ord.ShowDialog();
        }

        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            Race rc = new Race();this.Hide();rc.ShowDialog();
        }
    }
}
