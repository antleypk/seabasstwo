﻿using System;
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
    public partial class Loop : Form
    {
        public Loop()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            Operator operations = new Operator();

            if (radioKeyGen.Checked == true)
            {
                this.Hide();
                operations.keyGen();

            }
            if (radioEncrypt.Checked == true)
            {
                operations.encrypt();
                this.Hide();
                //taco
            }
            if (radioDecrypt.Checked == true)
            {
                operations.decrypt();
                this.Hide();

            }
            if (radioExit.Checked == true)
            {
                operations.loop();
                this.Hide();
                Application.Exit();

            }


        }

        private void radioEncrypt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Loop_Load(object sender, EventArgs e)
        {

        }
    }
}
