namespace seaBass
{
    partial class HideMe
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
            this.labelKeyInput = new System.Windows.Forms.Label();
            this.txtBXKeyIn = new System.Windows.Forms.TextBox();
            this.lblMessageIn = new System.Windows.Forms.Label();
            this.lblMessageOutputTitle = new System.Windows.Forms.Label();
            this.btnProccess = new System.Windows.Forms.Button();
            this.btnResetHideMe = new System.Windows.Forms.Button();
            this.txtBoxMessageIn = new System.Windows.Forms.TextBox();
            this.txtBoxCodedOut = new System.Windows.Forms.TextBox();
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.lblDecoded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKeyInput
            // 
            this.labelKeyInput.AutoSize = true;
            this.labelKeyInput.Location = new System.Drawing.Point(36, 9);
            this.labelKeyInput.Name = "labelKeyInput";
            this.labelKeyInput.Size = new System.Drawing.Size(32, 17);
            this.labelKeyInput.TabIndex = 0;
            this.labelKeyInput.Text = "Key";
            // 
            // txtBXKeyIn
            // 
            this.txtBXKeyIn.Location = new System.Drawing.Point(35, 41);
            this.txtBXKeyIn.Multiline = true;
            this.txtBXKeyIn.Name = "txtBXKeyIn";
            this.txtBXKeyIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBXKeyIn.Size = new System.Drawing.Size(419, 73);
            this.txtBXKeyIn.TabIndex = 1;
            this.txtBXKeyIn.TextChanged += new System.EventHandler(this.txtBXKeyIn_TextChanged);
            // 
            // lblMessageIn
            // 
            this.lblMessageIn.AutoSize = true;
            this.lblMessageIn.Location = new System.Drawing.Point(32, 117);
            this.lblMessageIn.Name = "lblMessageIn";
            this.lblMessageIn.Size = new System.Drawing.Size(80, 17);
            this.lblMessageIn.TabIndex = 2;
            this.lblMessageIn.Text = "Message In";
            this.lblMessageIn.Click += new System.EventHandler(this.lblMessageIn_Click);
            // 
            // lblMessageOutputTitle
            // 
            this.lblMessageOutputTitle.AutoSize = true;
            this.lblMessageOutputTitle.Location = new System.Drawing.Point(36, 268);
            this.lblMessageOutputTitle.Name = "lblMessageOutputTitle";
            this.lblMessageOutputTitle.Size = new System.Drawing.Size(112, 17);
            this.lblMessageOutputTitle.TabIndex = 3;
            this.lblMessageOutputTitle.Text = "Message Output";
            // 
            // btnProccess
            // 
            this.btnProccess.Location = new System.Drawing.Point(66, 234);
            this.btnProccess.Name = "btnProccess";
            this.btnProccess.Size = new System.Drawing.Size(154, 31);
            this.btnProccess.TabIndex = 5;
            this.btnProccess.Text = "Process";
            this.btnProccess.UseVisualStyleBackColor = true;
            this.btnProccess.Click += new System.EventHandler(this.btnProccess_Click);
            // 
            // btnResetHideMe
            // 
            this.btnResetHideMe.Location = new System.Drawing.Point(260, 234);
            this.btnResetHideMe.Name = "btnResetHideMe";
            this.btnResetHideMe.Size = new System.Drawing.Size(136, 31);
            this.btnResetHideMe.TabIndex = 6;
            this.btnResetHideMe.Text = "Reset";
            this.btnResetHideMe.UseVisualStyleBackColor = true;
            this.btnResetHideMe.Click += new System.EventHandler(this.btnResetHideMe_Click);
            // 
            // txtBoxMessageIn
            // 
            this.txtBoxMessageIn.Location = new System.Drawing.Point(35, 137);
            this.txtBoxMessageIn.Multiline = true;
            this.txtBoxMessageIn.Name = "txtBoxMessageIn";
            this.txtBoxMessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxMessageIn.Size = new System.Drawing.Size(419, 91);
            this.txtBoxMessageIn.TabIndex = 8;
            // 
            // txtBoxCodedOut
            // 
            this.txtBoxCodedOut.Location = new System.Drawing.Point(35, 288);
            this.txtBoxCodedOut.Multiline = true;
            this.txtBoxCodedOut.Name = "txtBoxCodedOut";
            this.txtBoxCodedOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCodedOut.Size = new System.Drawing.Size(416, 96);
            this.txtBoxCodedOut.TabIndex = 9;
            // 
            // txtDecoded
            // 
            this.txtDecoded.Location = new System.Drawing.Point(35, 414);
            this.txtDecoded.Multiline = true;
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecoded.Size = new System.Drawing.Size(413, 80);
            this.txtDecoded.TabIndex = 10;
            // 
            // lblDecoded
            // 
            this.lblDecoded.AutoSize = true;
            this.lblDecoded.Location = new System.Drawing.Point(39, 391);
            this.lblDecoded.Name = "lblDecoded";
            this.lblDecoded.Size = new System.Drawing.Size(65, 17);
            this.lblDecoded.TabIndex = 11;
            this.lblDecoded.Text = "Decoded";
            // 
            // HideMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 517);
            this.Controls.Add(this.lblDecoded);
            this.Controls.Add(this.txtDecoded);
            this.Controls.Add(this.txtBoxCodedOut);
            this.Controls.Add(this.txtBoxMessageIn);
            this.Controls.Add(this.btnResetHideMe);
            this.Controls.Add(this.btnProccess);
            this.Controls.Add(this.lblMessageOutputTitle);
            this.Controls.Add(this.lblMessageIn);
            this.Controls.Add(this.txtBXKeyIn);
            this.Controls.Add(this.labelKeyInput);
            this.Name = "HideMe";
            this.Text = "HideMe";
            this.Load += new System.EventHandler(this.HideMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeyInput;
        private System.Windows.Forms.TextBox txtBXKeyIn;
        private System.Windows.Forms.Label lblMessageIn;
        private System.Windows.Forms.Label lblMessageOutputTitle;
        private System.Windows.Forms.Button btnProccess;
        private System.Windows.Forms.Button btnResetHideMe;
        private System.Windows.Forms.TextBox txtBoxMessageIn;
        private System.Windows.Forms.TextBox txtBoxCodedOut;
        private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.Label lblDecoded;
    }
}