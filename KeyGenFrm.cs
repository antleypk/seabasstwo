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
            long length;
            string key = "";
            bool parse;
            string lengthString = lblKeyLengthInput.Text;   
            parse=Int64.TryParse(lengthString, out length);
            //convert and parse the input into numerical data
            //make loop that randomly generates a string of letters
            //stack overflow, parsing a string, into an , int x is the length
            // of the input string 
            //string alpha="abcdefghijklmnopqrstuvwxyz .@0123456789";
            // string key
            // for( int i=0, i<x; i++ ){
            //             
            //            Random r = new Random();  look this up on google
            // Key = Key + alpha.elementat(i);
            // }
            Concealer keyGen = new Concealer();
            if (rdbtnNoString.Checked == true && parse==true)
            {
             //   long length = 50;
            //   key= keyGenWstar(length);
            }
            if (rdbtnString.Checked == true && parse == true)
            {
                //   long length = 50;
                key = keyGen.keyGenWstar(passPhrase,length);
            }

            txtKeyOutput.Text = key;
            //txtKeyOutput.Text = key;
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
    }
}
