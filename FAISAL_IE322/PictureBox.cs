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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PctBox.Image = Image.FromFile("C:\\Users\\faisa\\OneDrive\\Desktop\\kau background.jpg");
        }
        private void PctBox_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
