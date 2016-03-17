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
            string newMessage= conceal.conceal(message, key);
            string unscramble = conceal.deConCeal(newMessage, key);
            txtBoxCodedOut.Text = newMessage;
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
    }
}
