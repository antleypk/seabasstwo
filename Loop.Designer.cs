namespace seaBass
{
    partial class Loop
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
            this.lblDoGood = new System.Windows.Forms.Label();
            this.grpBxOptions = new System.Windows.Forms.GroupBox();
            this.radioExit = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioKeyGen = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.grpBxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoGood
            // 
            this.lblDoGood.AutoSize = true;
            this.lblDoGood.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoGood.ForeColor = System.Drawing.Color.Red;
            this.lblDoGood.Location = new System.Drawing.Point(40, 9);
            this.lblDoGood.Name = "lblDoGood";
            this.lblDoGood.Size = new System.Drawing.Size(181, 55);
            this.lblDoGood.TabIndex = 0;
            this.lblDoGood.Text = "Do Good!";
            // 
            // grpBxOptions
            // 
            this.grpBxOptions.Controls.Add(this.radioExit);
            this.grpBxOptions.Controls.Add(this.radioDecrypt);
            this.grpBxOptions.Controls.Add(this.radioEncrypt);
            this.grpBxOptions.Controls.Add(this.radioKeyGen);
            this.grpBxOptions.Location = new System.Drawing.Point(28, 69);
            this.grpBxOptions.Name = "grpBxOptions";
            this.grpBxOptions.Size = new System.Drawing.Size(242, 137);
            this.grpBxOptions.TabIndex = 1;
            this.grpBxOptions.TabStop = false;
            // 
            // radioExit
            // 
            this.radioExit.AutoSize = true;
            this.radioExit.Location = new System.Drawing.Point(22, 106);
            this.radioExit.Name = "radioExit";
            this.radioExit.Size = new System.Drawing.Size(51, 21);
            this.radioExit.TabIndex = 3;
            this.radioExit.Text = "Exit";
            this.radioExit.UseVisualStyleBackColor = true;
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(22, 78);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(78, 21);
            this.radioDecrypt.TabIndex = 2;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Location = new System.Drawing.Point(22, 50);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(77, 21);
            this.radioEncrypt.TabIndex = 1;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            this.radioEncrypt.CheckedChanged += new System.EventHandler(this.radioEncrypt_CheckedChanged);
            // 
            // radioKeyGen
            // 
            this.radioKeyGen.AutoSize = true;
            this.radioKeyGen.Checked = true;
            this.radioKeyGen.Location = new System.Drawing.Point(22, 22);
            this.radioKeyGen.Name = "radioKeyGen";
            this.radioKeyGen.Size = new System.Drawing.Size(84, 21);
            this.radioKeyGen.TabIndex = 0;
            this.radioKeyGen.TabStop = true;
            this.radioKeyGen.Text = "Key Gen";
            this.radioKeyGen.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(50, 213);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Loop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpBxOptions);
            this.Controls.Add(this.lblDoGood);
            this.Name = "Loop";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Loop_Load);
            this.grpBxOptions.ResumeLayout(false);
            this.grpBxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoGood;
        private System.Windows.Forms.GroupBox grpBxOptions;
        private System.Windows.Forms.RadioButton radioExit;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.RadioButton radioKeyGen;
        private System.Windows.Forms.Button btnProcess;
    }
}