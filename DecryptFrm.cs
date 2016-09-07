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
    public partial class DecryptFrm : Form
    {
        public DecryptFrm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCodeIn.ResetText();
            txtDecryptKeyIn.ResetText();
            txtCodeOut.ResetText();
        }

        private void DecryptFrm_Load(object sender, EventArgs e)
        {

        }

        private void txtDecryptKeyIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Concealer reveal = new Concealer();
            string key = txtDecryptKeyIn.Text;
            string messageIn = txtCodeIn.Text;
            string messageOut = reveal.deConCeal(messageIn, key);
            txtCodeOut.Text = messageOut;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Operator operations = new Operator();
            this.Hide();
            operations.loop();
            
        }

        private void btnCopyDecode_Click(object sender, EventArgs e)
        {
            txtCodeOut.SelectAll();
            txtCodeOut.Copy();
            Process.Start("notepad.exe", "text.txt");
            System.IO.File.WriteAllText("text.txt", txtCodeOut.Text);
        }
    }
}
