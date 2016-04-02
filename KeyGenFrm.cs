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



            Concealer keyGen = new Concealer();
            key = keyGen.keyGen(length);
            txtKeyOutput.Text = "hello world "+key.Count()+"!";
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
