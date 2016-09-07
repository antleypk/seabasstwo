namespace seaBass
{
    partial class DecryptFrm
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
            this.lblDecryptKey = new System.Windows.Forms.Label();
            this.txtDecryptKeyIn = new System.Windows.Forms.TextBox();
            this.txtCodeIn = new System.Windows.Forms.TextBox();
            this.txtCodeOut = new System.Windows.Forms.TextBox();
            this.lblKeyIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnCopyDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecryptKey
            // 
            this.lblDecryptKey.AutoSize = true;
            this.lblDecryptKey.Location = new System.Drawing.Point(67, 34);
            this.lblDecryptKey.Name = "lblDecryptKey";
            this.lblDecryptKey.Size = new System.Drawing.Size(47, 17);
            this.lblDecryptKey.TabIndex = 0;
            this.lblDecryptKey.Text = "Key In";
            // 
            // txtDecyptKeyIn
            // 
            this.txtDecryptKeyIn.Location = new System.Drawing.Point(70, 68);
            this.txtDecryptKeyIn.Multiline = true;
            this.txtDecryptKeyIn.Name = "txtDecryptKeyIn";
            this.txtDecryptKeyIn.Size = new System.Drawing.Size(310, 52);
            this.txtDecryptKeyIn.TabIndex = 1;
            this.txtDecryptKeyIn.TextChanged += new System.EventHandler(this.txtDecryptKeyIn_TextChanged);
            // 
            // txtCodeIn
            // 
            this.txtCodeIn.Location = new System.Drawing.Point(70, 143);
            this.txtCodeIn.Multiline = true;
            this.txtCodeIn.Name = "txtCodeIn";
            this.txtCodeIn.Size = new System.Drawing.Size(310, 45);
            this.txtCodeIn.TabIndex = 2;
            this.txtCodeIn.TextChanged += new System.EventHandler(this.txtCodeIn_TextChanged);
            // 
            // txtCodeOut
            // 
            this.txtCodeOut.Location = new System.Drawing.Point(70, 228);
            this.txtCodeOut.Multiline = true;
            this.txtCodeOut.Name = "txtCodeOut";
            this.txtCodeOut.Size = new System.Drawing.Size(310, 46);
            this.txtCodeOut.TabIndex = 3;
            this.txtCodeOut.TextChanged += new System.EventHandler(this.txtCodeOut_TextChanged);
            // 
            // lblKeyIn
            // 
            this.lblKeyIn.AutoSize = true;
            this.lblKeyIn.Location = new System.Drawing.Point(70, 123);
            this.lblKeyIn.Name = "lblKeyIn";
            this.lblKeyIn.Size = new System.Drawing.Size(125, 17);
            this.lblKeyIn.TabIndex = 5;
            this.lblKeyIn.Text = "Coded Message In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message Output";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 288);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(174, 288);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(92, 23);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnCopyDecode
            // 
            this.btnCopyDecode.Location = new System.Drawing.Point(272, 288);
            this.btnCopyDecode.Name = "btnCopyDecode";
            this.btnCopyDecode.Size = new System.Drawing.Size(128, 23);
            this.btnCopyDecode.TabIndex = 10;
            this.btnCopyDecode.Text = "Copy Decoded";
            this.btnCopyDecode.UseVisualStyleBackColor = true;
            this.btnCopyDecode.Click += new System.EventHandler(this.btnCopyDecode_Click);
            // 
            // DecryptFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 323);
            this.Controls.Add(this.btnCopyDecode);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKeyIn);
            this.Controls.Add(this.txtCodeOut);
            this.Controls.Add(this.txtCodeIn);
            this.Controls.Add(this.txtDecryptKeyIn);
            this.Controls.Add(this.lblDecryptKey);
            this.Name = "DecryptFrm";
            this.Text = "Show me the message";
            this.Load += new System.EventHandler(this.DecryptFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecryptKey;
        private System.Windows.Forms.TextBox txtDecryptKeyIn;
        private System.Windows.Forms.TextBox txtCodeIn;
        private System.Windows.Forms.TextBox txtCodeOut;
        private System.Windows.Forms.Label lblKeyIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnCopyDecode;
    }
}