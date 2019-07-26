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
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order fr = new Order();
            fr.ShowDialog();
            
        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.ShowDialog();
        }

        private void BtnGames_Click(object sender, EventArgs e)
        {
            Race rc = new Race();this.Hide();rc.ShowDialog();
        }
    }
}
