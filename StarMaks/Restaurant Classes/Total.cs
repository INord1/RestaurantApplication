using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StarMaks
{
    class Total:OrderP
    {
        public Total(TextBox txtBorsh, TextBox txtCake, TextBox txtChay, TextBox txtCofee, TextBox txtJuice, TextBox txtMeat, TextBox txtPelmeny,
              TextBox txtVodka, TextBox txtCostOfDrink, CheckBox _chCake, CheckBox _chCofee, CheckBox _chChai, CheckBox _ckBorsh, CheckBox _chjuice, CheckBox _chmeat, CheckBox _chpelmeny, CheckBox _chvodka, TextBox txtTax
              ,TextBox _txtFULPRice)
        {
            Borsh = txtBorsh; Cake = txtCake; Cofee = txtCofee; Juce = txtJuice; Meat = txtMeat; Pelmeny = txtPelmeny;
            Vodka = txtVodka; cost = txtCostOfDrink; ckCake = _chCake; chCofee = _chCofee; chChay = _chChai; chBorsh = _ckBorsh;
            chJuse = _chjuice; chMeat = _chmeat; chPelmeny = _chpelmeny; chVodka = _chvodka; Tax = txtTax;txtFullPRICE = _txtFULPRice;
           
        }

        public void total()
        {


            double price = 0; double test = 0;
            double taxPay = 0.50, chay = 1, cofee = 2.50, juse = 3, vodka = 3.50,
           pelmeny = 2.47, meat = 2.12, borsh = 5, cacke = 3, serviseCharje = 0.10;


            if (chBorsh.Checked == true) { test = Convert.ToDouble(Borsh.Text) * borsh; price += test; }



            if (ckCake.Checked == true) { test = Convert.ToDouble(Cake.Text) * cacke; price += test; }

          // I made invisible if (chChay.Checked == true) { test = Convert.ToDouble(Chay.Text) * chay; price += test; }

            if (chCofee.Checked == true) { test = Convert.ToDouble(Cofee.Text) * cofee; price += test; }

            if (chJuse.Checked == true) { test = Convert.ToDouble(Juce.Text) * juse; price += test; }

            if (chMeat.Checked == true) { test = Convert.ToDouble(Meat.Text) * meat; price += test; }

            if (chPelmeny.Checked == true) { test = Convert.ToDouble(Pelmeny.Text) * pelmeny; price += test; }

            if (chVodka.Checked == true) { test = Convert.ToDouble(Vodka.Text) * vodka; price += test; }

            double bonusCharje = Convert.ToDouble((price + serviseCharje) * taxPay / 100);
            double totalT = price + bonusCharje;
          


            Tax.Text = Convert.ToString(Math.Round(bonusCharje, 2));
           
            cost.Text = Convert.ToString(Math.Round(totalT,2));

            double fullPrice = Convert.ToDouble(Tax.Text) + Convert.ToDouble(cost.Text);
            txtFullPRICE.Text = Convert.ToString(Math.Round(fullPrice, 2));
        }
          
       public double totalLogic(TextBox txtItem,double item,double price,double test)
        {
            test = Convert.ToDouble(txtItem.Text) * item; price += test;
            return test;
        }

     
       
    }
}
