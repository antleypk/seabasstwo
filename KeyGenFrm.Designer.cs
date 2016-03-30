namespace seaBass
{
    partial class KeyGenFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKeyOutput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblStringIn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKeyLengthInput = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbtnString = new System.Windows.Forms.RadioButton();
            this.rdbtnNoString = new System.Windows.Forms.RadioButton();
            this.gbSringRadio = new System.Windows.Forms.GroupBox();
            this.gbSringRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyOutput
            // 
            this.txtKeyOutput.Location = new System.Drawing.Point(12, 171);
            this.txtKeyOutput.Multiline = true;
            this.txtKeyOutput.Name = "txtKeyOutput";
            this.txtKeyOutput.Size = new System.Drawing.Size(260, 78);
            this.txtKeyOutput.TabIndex = 0;
            this.txtKeyOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(179, 136);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(93, 29);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(9, 136);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output";
            // 
            // lblStringIn
            // 
            this.lblStringIn.AutoSize = true;
            this.lblStringIn.Location = new System.Drawing.Point(12, 13);
            this.lblStringIn.Name = "lblStringIn";
            this.lblStringIn.Size = new System.Drawing.Size(46, 13);
            this.lblStringIn.TabIndex = 3;
            this.lblStringIn.Text = "String In";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblKeyLengthInput
            // 
            this.lblKeyLengthInput.AutoSize = true;
            this.lblKeyLengthInput.Location = new System.Drawing.Point(9, 29);
            this.lblKeyLengthInput.Name = "lblKeyLengthInput";
            this.lblKeyLengthInput.Size = new System.Drawing.Size(100, 13);
            this.lblKeyLengthInput.TabIndex = 5;
            this.lblKeyLengthInput.Text = "Input Length of Key";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rdbtnString
            // 
            this.rdbtnString.AutoSize = true;
            this.rdbtnString.Location = new System.Drawing.Point(6, 19);
            this.rdbtnString.Name = "rdbtnString";
            this.rdbtnString.Size = new System.Drawing.Size(52, 17);
            this.rdbtnString.TabIndex = 7;
            this.rdbtnString.TabStop = true;
            this.rdbtnString.Text = "String";
            this.rdbtnString.UseVisualStyleBackColor = true;
            this.rdbtnString.CheckedChanged += new System.EventHandler(this.rdbtnString_CheckedChanged);
            // 
            // rdbtnNoString
            // 
            this.rdbtnNoString.AutoSize = true;
            this.rdbtnNoString.Location = new System.Drawing.Point(6, 41);
            this.rdbtnNoString.Name = "rdbtnNoString";
            this.rdbtnNoString.Size = new System.Drawing.Size(69, 17);
            this.rdbtnNoString.TabIndex = 8;
            this.rdbtnNoString.TabStop = true;
            this.rdbtnNoString.Text = "No String";
            this.rdbtnNoString.UseVisualStyleBackColor = true;
            this.rdbtnNoString.CheckedChanged += new System.EventHandler(this.rdbtnNoString_CheckedChanged);
            // 
            // gbSringRadio
            // 
            this.gbSringRadio.Controls.Add(this.rdbtnString);
            this.gbSringRadio.Controls.Add(this.rdbtnNoString);
            this.gbSringRadio.Location = new System.Drawing.Point(23, 60);
            this.gbSringRadio.Name = "gbSringRadio";
            this.gbSringRadio.Size = new System.Drawing.Size(86, 64);
            this.gbSringRadio.TabIndex = 9;
            this.gbSringRadio.TabStop = false;
            this.gbSringRadio.Enter += new System.EventHandler(this.gbSringRadio_Enter);
            // 
            // KeyGenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbSringRadio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblKeyLengthInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStringIn);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtKeyOutput);
            this.Name = "KeyGenFrm";
            this.Text = "KeyGenFrm";
            this.Load += new System.EventHandler(this.KeyGenFrm_Load);
            this.gbSringRadio.ResumeLayout(false);
            this.gbSringRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyOutput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblStringIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKeyLengthInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdbtnString;
        private System.Windows.Forms.RadioButton rdbtnNoString;
        private System.Windows.Forms.GroupBox gbSringRadio;
    }
}