using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class CheckUncheckConditions
    {

        internal static void CheckConditions(TextBox txt1, CheckBox ch1)
        {

            txt1.Enabled = true; txt1.Text = 0.ToString();
            txt1.Enabled = (ch1.CheckState == CheckState.Checked);
        }



        
    }
}
