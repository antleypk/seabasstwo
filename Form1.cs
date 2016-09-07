using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seaBass
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();


          

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void StartUpForm_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBoxStartOptions_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Operator operations = new Operator();

            if (radioDecrypt.Checked == true)
            {
                this.Hide();
                operations.decrypt();
    
            }
            if (radioEncrypt.Checked == true)
            {
                operations.encrypt();
                this.Hide();
                //taco
            }
            if (radioKeyGen.Checked == true)
            {
                operations.keyGen();
                this.Hide();

            }
           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetStartButtons();

        }

        public void resetStartButtons()
        {
            radioEncrypt.Checked = false;
            radioDecrypt.Checked = false;
            radioKeyGen.Checked = false;
        }
        private void radioDecrypt_CheckedChanged(object sender, EventArgs e)
        {

            //resetStartButtons();
            radioDecrypt.Checked = true;

           
        }

        private void radioKeyGen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
