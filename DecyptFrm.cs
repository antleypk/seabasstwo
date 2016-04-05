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
    public partial class DecyptFrm : Form
    {
        public DecyptFrm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCodeIn.ResetText();
            txtDecyptKeyIn.ResetText();
            txtCodeOut.ResetText();
        }

        private void DecyptFrm_Load(object sender, EventArgs e)
        {

        }

        private void txtDecyptKeyIn_TextChanged(object sender, EventArgs e)
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
            string key = txtDecyptKeyIn.Text;
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
