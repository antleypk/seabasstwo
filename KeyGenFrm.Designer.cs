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
            this.txtStringIn = new System.Windows.Forms.TextBox();
            this.lblKeyLengthInput = new System.Windows.Forms.Label();
            this.txtinputlength = new System.Windows.Forms.TextBox();
            this.rdbtnString = new System.Windows.Forms.RadioButton();
            this.rdbtnNoString = new System.Windows.Forms.RadioButton();
            this.gbSringRadio = new System.Windows.Forms.GroupBox();
            this.btnSelectNCopy = new System.Windows.Forms.Button();
            this.lblRationIn = new System.Windows.Forms.Label();
            this.txtRatioIN = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gbSringRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyOutput
            // 
            this.txtKeyOutput.Location = new System.Drawing.Point(16, 210);
            this.txtKeyOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyOutput.Multiline = true;
            this.txtKeyOutput.Name = "txtKeyOutput";
            this.txtKeyOutput.Size = new System.Drawing.Size(345, 95);
            this.txtKeyOutput.TabIndex = 0;
            this.txtKeyOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(239, 167);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(124, 36);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 167);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 17);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output";
            // 
            // lblStringIn
            // 
            this.lblStringIn.AutoSize = true;
            this.lblStringIn.Location = new System.Drawing.Point(16, 16);
            this.lblStringIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStringIn.Name = "lblStringIn";
            this.lblStringIn.Size = new System.Drawing.Size(60, 17);
            this.lblStringIn.TabIndex = 3;
            this.lblStringIn.Text = "String In";
            // 
            // txtStringIn
            // 
            this.txtStringIn.Location = new System.Drawing.Point(87, 6);
            this.txtStringIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtStringIn.Multiline = true;
            this.txtStringIn.Name = "txtStringIn";
            this.txtStringIn.Size = new System.Drawing.Size(275, 25);
            this.txtStringIn.TabIndex = 4;
            this.txtStringIn.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblKeyLengthInput
            // 
            this.lblKeyLengthInput.AutoSize = true;
            this.lblKeyLengthInput.Location = new System.Drawing.Point(12, 36);
            this.lblKeyLengthInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeyLengthInput.Name = "lblKeyLengthInput";
            this.lblKeyLengthInput.Size = new System.Drawing.Size(131, 17);
            this.lblKeyLengthInput.TabIndex = 5;
            this.lblKeyLengthInput.Text = "Input Length of Key";
            // 
            // txtinputlength
            // 
            this.txtinputlength.Location = new System.Drawing.Point(155, 36);
            this.txtinputlength.Margin = new System.Windows.Forms.Padding(4);
            this.txtinputlength.Name = "txtinputlength";
            this.txtinputlength.Size = new System.Drawing.Size(207, 22);
            this.txtinputlength.TabIndex = 6;
            this.txtinputlength.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rdbtnString
            // 
            this.rdbtnString.AutoSize = true;
            this.rdbtnString.Location = new System.Drawing.Point(8, 23);
            this.rdbtnString.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnString.Name = "rdbtnString";
            this.rdbtnString.Size = new System.Drawing.Size(66, 21);
            this.rdbtnString.TabIndex = 7;
            this.rdbtnString.TabStop = true;
            this.rdbtnString.Text = "String";
            this.rdbtnString.UseVisualStyleBackColor = true;
            this.rdbtnString.CheckedChanged += new System.EventHandler(this.rdbtnString_CheckedChanged);
            // 
            // rdbtnNoString
            // 
            this.rdbtnNoString.AutoSize = true;
            this.rdbtnNoString.Location = new System.Drawing.Point(8, 50);
            this.rdbtnNoString.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnNoString.Name = "rdbtnNoString";
            this.rdbtnNoString.Size = new System.Drawing.Size(88, 21);
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
            this.gbSringRadio.Location = new System.Drawing.Point(31, 74);
            this.gbSringRadio.Margin = new System.Windows.Forms.Padding(4);
            this.gbSringRadio.Name = "gbSringRadio";
            this.gbSringRadio.Padding = new System.Windows.Forms.Padding(4);
            this.gbSringRadio.Size = new System.Drawing.Size(115, 79);
            this.gbSringRadio.TabIndex = 9;
            this.gbSringRadio.TabStop = false;
            this.gbSringRadio.Enter += new System.EventHandler(this.gbSringRadio_Enter);
            // 
            // btnSelectNCopy
            // 
            this.btnSelectNCopy.Location = new System.Drawing.Point(155, 167);
            this.btnSelectNCopy.Name = "btnSelectNCopy";
            this.btnSelectNCopy.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNCopy.TabIndex = 10;
            this.btnSelectNCopy.Text = "Copy";
            this.btnSelectNCopy.UseVisualStyleBackColor = true;
            this.btnSelectNCopy.Click += new System.EventHandler(this.btnSelectNCopy_Click);
            // 
            // lblRationIn
            // 
            this.lblRationIn.AutoSize = true;
            this.lblRationIn.Location = new System.Drawing.Point(155, 74);
            this.lblRationIn.Name = "lblRationIn";
            this.lblRationIn.Size = new System.Drawing.Size(97, 17);
            this.lblRationIn.TabIndex = 11;
            this.lblRationIn.Text = "Ratio 1-100int";
            // 
            // txtRatioIN
            // 
            this.txtRatioIN.Location = new System.Drawing.Point(270, 74);
            this.txtRatioIN.Name = "txtRatioIN";
            this.txtRatioIN.Size = new System.Drawing.Size(91, 22);
            this.txtRatioIN.TabIndex = 12;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(74, 167);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // KeyGenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtRatioIN);
            this.Controls.Add(this.lblRationIn);
            this.Controls.Add(this.btnSelectNCopy);
            this.Controls.Add(this.gbSringRadio);
            this.Controls.Add(this.txtinputlength);
            this.Controls.Add(this.lblKeyLengthInput);
            this.Controls.Add(this.txtStringIn);
            this.Controls.Add(this.lblStringIn);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtKeyOutput);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtStringIn;
        private System.Windows.Forms.Label lblKeyLengthInput;
        private System.Windows.Forms.TextBox txtinputlength;
        private System.Windows.Forms.RadioButton rdbtnString;
        private System.Windows.Forms.RadioButton rdbtnNoString;
        private System.Windows.Forms.GroupBox gbSringRadio;
        private System.Windows.Forms.Button btnSelectNCopy;
        private System.Windows.Forms.Label lblRationIn;
        private System.Windows.Forms.TextBox txtRatioIN;
        private System.Windows.Forms.Button btnMenu;
    }
}