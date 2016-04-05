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
    public partial class HideMe : Form
    {
        public HideMe()
        {
            InitializeComponent();
        }

        private void HideMe_Load(object sender, EventArgs e)
        {

        }

        private void btnProccess_Click(object sender, EventArgs e)
        {
            
            string message = txtBoxMessageIn.Text;
            string key = txtBXKeyIn.Text;

            Concealer conceal = new Concealer();
            List<List<Int32>> keyDistribution = conceal.letterDistributionMK2(message);
           // String diagnose="there are " + keyDistribution.ElementAt(0).Count() + " a's in the key";
            string newMessage= conceal.conceal(message, key);
           string unscramble = conceal.deConCeal(newMessage, key);
           int aCount= keyDistribution.ElementAt(0).Count();
           // string aCountString = "the count of a's in the message is " + aCount;
            txtBoxCodedOut.Text = newMessage;
            txtDecoded.Text = unscramble;
            //txtBoxCodedOut.Text = diagnose;
        }

        private void btnResetHideMe_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txtBXKeyIn.ResetText();
            txtBoxMessageIn.ResetText();
            txtBoxCodedOut.ResetText();
        }

        private void txtBXKeyIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessageIn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("input a key and a message to recieve a coded message");
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            txtBoxCodedOut.SelectAll();
            txtBoxCodedOut.Copy();
            Process.Start("notepad.exe", "coded.txt");
            System.IO.File.WriteAllText("coded.txt", txtBoxCodedOut.Text);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Operator operations = new Operator();
            this.Hide();
            operations.loop();
        }
    }
}
