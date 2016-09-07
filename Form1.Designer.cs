namespace seaBass
{
    partial class StartUpForm
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
            this.radioKeyGen = new System.Windows.Forms.RadioButton();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.groupBoxStartOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelCommonIntel = new System.Windows.Forms.LinkLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.groupBoxStartOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioKeyGen
            // 
            this.radioKeyGen.AutoSize = true;
            this.radioKeyGen.Location = new System.Drawing.Point(42, 21);
            this.radioKeyGen.Name = "radioKeyGen";
            this.radioKeyGen.Size = new System.Drawing.Size(117, 21);
            this.radioKeyGen.TabIndex = 0;
            this.radioKeyGen.TabStop = true;
            this.radioKeyGen.Text = "Key Generate";
            this.radioKeyGen.UseVisualStyleBackColor = true;
            this.radioKeyGen.CheckedChanged += new System.EventHandler(this.radioKeyGen_CheckedChanged);
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Location = new System.Drawing.Point(42, 48);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(77, 21);
            this.radioEncrypt.TabIndex = 1;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(42, 75);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(78, 21);
            this.radioDecrypt.TabIndex = 2;
            this.radioDecrypt.TabStop = true;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            this.radioDecrypt.CheckedChanged += new System.EventHandler(this.radioDecrypt_CheckedChanged);
            // 
            // groupBoxStartOptions
            // 
            this.groupBoxStartOptions.Controls.Add(this.radioKeyGen);
            this.groupBoxStartOptions.Controls.Add(this.radioDecrypt);
            this.groupBoxStartOptions.Controls.Add(this.radioEncrypt);
            this.groupBoxStartOptions.Location = new System.Drawing.Point(73, 82);
            this.groupBoxStartOptions.Name = "groupBoxStartOptions";
            this.groupBoxStartOptions.Size = new System.Drawing.Size(208, 115);
            this.groupBoxStartOptions.TabIndex = 3;
            this.groupBoxStartOptions.TabStop = false;
            this.groupBoxStartOptions.Text = "Select Option";
            this.groupBoxStartOptions.Enter += new System.EventHandler(this.groupBoxStartOptions_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Franklin\'s Gift";
            // 
            // linkLabelCommonIntel
            // 
            this.linkLabelCommonIntel.AutoSize = true;
            this.linkLabelCommonIntel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelCommonIntel.Location = new System.Drawing.Point(170, 250);
            this.linkLabelCommonIntel.Name = "linkLabelCommonIntel";
            this.linkLabelCommonIntel.Size = new System.Drawing.Size(115, 17);
            this.linkLabelCommonIntel.TabIndex = 5;
            this.linkLabelCommonIntel.TabStop = true;
            this.linkLabelCommonIntel.Text = "Common Intellect";
            this.linkLabelCommonIntel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(73, 203);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 44);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(181, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.titleLabel.Location = new System.Drawing.Point(67, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(248, 31);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Stingray Killer 5000";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 280);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.linkLabelCommonIntel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxStartOptions);
            this.Name = "StartUpForm";
            this.Text = "Common Concealment";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.groupBoxStartOptions.ResumeLayout(false);
            this.groupBoxStartOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioKeyGen;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.GroupBox groupBoxStartOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelCommonIntel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label titleLabel;
    }
}

