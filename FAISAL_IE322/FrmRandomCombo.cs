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
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Cmb1.ResetText();
            Cmb1.Items.Clear();
            Random r= new Random();
            for(int i = 0; i<r.Next(1,50)-1;i++)
            {
                Cmb1.Items.Add(r.Next(100, 999));
            }
        }
    }
}
