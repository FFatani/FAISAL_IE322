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
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void Random_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            BtnNum.Text = Convert.ToString(y.Next(1, 10));
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            LblRandom.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            BtnColor.BackColor=Color.FromArgb(r, g, b);

        }
    }
}
