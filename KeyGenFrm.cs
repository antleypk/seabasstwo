using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seaBass
{
    public partial class KeyGenFrm : Form
    {
        public KeyGenFrm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string passPhrase = lblStringIn.Text;
            Int32 length;
            
            bool parse;
            string lengthString = txtinputlength.Text; 
            parse=Int32.TryParse(lengthString, out length);

            bool parse2;
            int ratio;
            string ratioString = txtRatioIN.Text;
            parse2 = int.TryParse(ratioString, out ratio);


            if (length <= 100000)
            {
                genKey(length, ratio);
            }
            if (length > 100000)
            {
                txtinputlength.Text = "For preformance reasons must be less than 100,000";
            }


        }
        private void genKey(int length, int ratio)
        {
            string key = "";
            Concealer keyGen = new Concealer();
            String input = txtStringIn.Text;




            key = keyGen.keyGen(length,input,ratio);
            //txtKeyOutput.Text = "hello world "+key.Count()+"!";
            txtKeyOutput.Text = key;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbtnString_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnNoString_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbSringRadio_Enter(object sender, EventArgs e)
        {

        }

        private void KeyGenFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSelectNCopy_Click(object sender, EventArgs e)
        {
            txtKeyOutput.SelectAll();
            txtKeyOutput.Copy();
            Process.Start("notepad.exe", "key.txt");
            System.IO.File.WriteAllText("key.txt", txtKeyOutput.Text);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Operator operations = new Operator();
            this.Hide();
            operations.loop();
        }

        private void txtRatioIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKeyLengthInput_Click(object sender, EventArgs e)
        {

        }
    }
}
