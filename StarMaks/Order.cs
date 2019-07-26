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
    public partial class Order : Form
    {
        
        public Order()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString();

           

        }
        
        private void TxtChay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetButton.myMethod(txtBorsh,txtCake, txtChay, txtCofee, txtJuice
                , txtMeat, txtPelmeny, txtVodka
                , chCake, chChay, chCofee, chJuise, chVodka, ckBorsh, ckMeat,ckPelmeny,txtCostOfDrink,txtTaxes);
            rReceip.Text = ""; txtTotal.Text = "0";
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            Total t = new Total(txtBorsh, txtCake, txtChay, txtCofee, txtJuice
                , txtMeat, txtPelmeny, txtVodka, txtCostOfDrink, chCake
                , chCofee, chChay, ckBorsh, chJuise, ckMeat, ckPelmeny, chVodka,txtTaxes,txtTotal);

            t.total();
          



        }

        private void CkBorsh_CheckedChanged(object sender, EventArgs e)
        {
            
            CheckUncheckConditions.CheckConditions(txtBorsh, ckBorsh);
            

        }

        private void ChCofee_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtCofee,chCofee);
        }

        private void ChJuise_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtJuice, chJuise);
        }

        private void ChVodka_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtVodka, chVodka);
        }

        private void ChCake_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtCake, chCake);
        }

        private void CkPelmeny_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtPelmeny, ckPelmeny);
        }

        private void CkMeat_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtMeat, ckMeat);
        }

        private void ChChay_CheckedChanged(object sender, EventArgs e)
        {
            CheckUncheckConditions.CheckConditions(txtChay, chChay);

        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            

            rReceip.Clear();
            rReceip.AppendText(Environment.NewLine);
            rReceip.AppendText("\t\t" + "Test Kafe " + Environment.NewLine);
            rReceip.AppendText("-----------------------------------------------" + Environment.NewLine);
           // rReceip.AppendText("Borsh \t\t" + txtBorsh + Environment.NewLine);
            rReceip.AppendText("Cake \t\t" + txtCake.Text + Environment.NewLine);
            //rReceip.AppendText("Chay \t\t" + txtChay.Text + Environment.NewLine);
            rReceip.AppendText("Coffee \t\t" + txtCofee.Text + Environment.NewLine);
            rReceip.AppendText("Jice \t\t" + txtJuice.Text + Environment.NewLine);
            rReceip.AppendText("Meat \t\t" + txtMeat.Text + Environment.NewLine);
            rReceip.AppendText("Pelmeny \t\t" + txtPelmeny.Text + Environment.NewLine);
            rReceip.AppendText("Vodka \t\t" + txtVodka.Text + Environment.NewLine);

            rReceip.AppendText("-------------------------------------------------" + Environment.NewLine);
            
            rReceip.AppendText("Tax \t\t" + txtTaxes.Text + Environment.NewLine);
            
            rReceip.AppendText("Total Cost \t\t" + txtTotal.Text + Environment.NewLine);
            rReceip.AppendText("--------------------------------------------------" + Environment.NewLine);
            rReceip.AppendText(lblDateTime.Text );
        }

        private void ToolNew_Click(object sender, EventArgs e)
        {
            rReceip.Clear();
        }

        private void ToolOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rReceip.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void ToolSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rReceip.Text);
            }
        }
        
        private void ToolCopy_Click(object sender, EventArgs e)
        {
            rReceip.Copy();
        }

        private void ToolPaste_Click(object sender, EventArgs e)
        {
            rReceip.Paste();
        }

        private void ToolHelp_Click(object sender, EventArgs e)
        {

        }

        private void TooCut_Click(object sender, EventArgs e)
        {
            rReceip.Cut();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeWindow mn = new WelcomeWindow();
            mn.ShowDialog();
        }

        private void RReceip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
