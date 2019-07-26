using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
   public  static class ResetButton
    {
       
      
        internal static void myMethod(
            TextBox txtBorsh, TextBox txtCake, TextBox txtChay, TextBox txtCofee, TextBox txtJuice, TextBox txtMeat, TextBox txtPelmeny, TextBox txtVodka
            , CheckBox chCake, CheckBox chChay, CheckBox chCofee, CheckBox chJuise, CheckBox chVodka, CheckBox ckBorsh, CheckBox ckMeat, CheckBox ckPelmeny,
            TextBox cost,TextBox taxes)
        {
            txtVodka.Text = 0.ToString();txtBorsh.Text = 0.ToString(); txtCake.Text = 0.ToString();
            txtChay.Text = 0.ToString();txtCofee.Text = 0.ToString(); txtJuice.Text = 0.ToString();
            txtMeat.Text = 0.ToString();txtPelmeny.Text = 0.ToString();cost.Text = 0.ToString();taxes.Text = 0.ToString();
            chCake.Checked = false; chChay.Checked = false; chCofee.Checked = false;
            chJuise.Checked = false; chVodka.Checked = false; ckBorsh.Checked = false;
            ckMeat.Checked = false; ckPelmeny.Checked = false; 


        }

       
    }
}
