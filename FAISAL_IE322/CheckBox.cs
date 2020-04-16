using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAISAL_IE322
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkBrownie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(ChkCoffee.Checked==true)
            {
                msg = ChkCoffee.Text;
            }
            if(ChkDonut.Checked==true)
            {
                msg =msg+" " +ChkDonut.Text;
            }
            if(ChkBrownie.Checked==true)
            {
                msg =msg+" " +ChkBrownie.Text;
            }
            if(msg.Length==0)
            {
                msg = "Nothing Selected";
            }
            MessageBox.Show(msg);

          
        }

        private void CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
