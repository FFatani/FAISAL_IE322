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
    public partial class Combo : Form
    {
        public Combo()

        {
            InitializeComponent();

            //Adding items to the Combobox
            CmbBox.Items.Add("Sunday");
            CmbBox.Items.Add("Monday");
            CmbBox.Items.Add("Tuesday");
            CmbBox.Items.Add("Wednesday");
            CmbBox.Items.Add("Thursday");
            CmbBox.Items.Add("Friday");
            CmbBox.Items.Add("Saturday");
        }

        private void BtnMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnMethod2_Click(object sender, EventArgs e)
        {
            var item = this.CmbBox.GetItemText(this.CmbBox.SelectedItem);
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            CmbBox.Items.Remove("Friday");
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            CmbBox.Items.RemoveAt(1);
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            if(CmbBox.Items.Count>=1)
            {
                CmbBox.Items.RemoveAt(CmbBox.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't remove last item");
                    }
        }

        private void BtnItem2_Click(object sender, EventArgs e)
        {
            if (CmbBox.Items.Count >= 2)
            {
                CmbBox.Items.RemoveAt(CmbBox.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't remove 2nd last item");
            }
        }

        private void Combo_Load(object sender, EventArgs e)
        {

        }
    }
}
