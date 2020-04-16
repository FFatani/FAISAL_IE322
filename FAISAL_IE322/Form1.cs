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
    public partial class FrmMain : Form
    {
        string username = "faisal";
        string myPassword = "1234";
        bool loggedIn = false;

        int attempt = 1;
        int MaxAttempts = 3;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox frm = new CheckBox();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Combo frm = new Combo();
            frm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "firas")
                if (TxtPass.Text == "1234")
                    MessageBox.Show("Login Successful");
                else
                    MessageBox.Show("Incorrect Paasword");

            else
            {
                MessageBox.Show("Incorrect Username");
            }
            while (attempt <= MaxAttempts)
            {
                if (TxtUser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    TxtUser.Clear();
                    TxtPass.Clear();
                    return;
                }
                else
                {   // username is correct
                    // so check password                        
                    if (TxtPass.Text != "1234")
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        TxtUser.Clear();
                        TxtPass.Clear();
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");
                        TxtUser.Clear();
                        TxtPass.Clear();



                        BtnLogin.Text = "Logout";
                     
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblPass_Click(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnRand_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnPicbox_Click(object sender, EventArgs e)
        {
            PictureBox frm = new PictureBox();
            frm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
