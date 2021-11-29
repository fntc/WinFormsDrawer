
namespace WinFormsDrawer
{
    partial class Form1
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
            this.btnOposOpen = new System.Windows.Forms.Button();
            this.btnOposClaim = new System.Windows.Forms.Button();
            this.btnOposClose = new System.Windows.Forms.Button();
            this.checkDeviceEnabled = new System.Windows.Forms.CheckBox();
            this.btnOposRelease = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrtOpen = new System.Windows.Forms.Button();
            this.btnPrtClose = new System.Windows.Forms.Button();
            this.btnPrtClaim = new System.Windows.Forms.Button();
            this.checkPrtEnabled = new System.Windows.Forms.CheckBox();
            this.btnPrtRelease = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOposOpen
            // 
            this.btnOposOpen.Location = new System.Drawing.Point(6, 27);
            this.btnOposOpen.Name = "btnOposOpen";
            this.btnOposOpen.Size = new System.Drawing.Size(75, 29);
            this.btnOposOpen.TabIndex = 0;
            this.btnOposOpen.Text = "Open";
            this.btnOposOpen.UseVisualStyleBackColor = true;
            this.btnOposOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOposOpen_MouseClick);
            // 
            // btnOposClaim
            // 
            this.btnOposClaim.Enabled = false;
            this.btnOposClaim.Location = new System.Drawing.Point(87, 27);
            this.btnOposClaim.Name = "btnOposClaim";
            this.btnOposClaim.Size = new System.Drawing.Size(75, 29);
            this.btnOposClaim.TabIndex = 1;
            this.btnOposClaim.Text = "Claim";
            this.btnOposClaim.UseVisualStyleBackColor = true;
            this.btnOposClaim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOposClaim_MouseClick);
            // 
            // btnOposClose
            // 
            this.btnOposClose.Enabled = false;
            this.btnOposClose.Location = new System.Drawing.Point(6, 62);
            this.btnOposClose.Name = "btnOposClose";
            this.btnOposClose.Size = new System.Drawing.Size(75, 27);
            this.btnOposClose.TabIndex = 2;
            this.btnOposClose.Text = "Close";
            this.btnOposClose.UseVisualStyleBackColor = true;
            this.btnOposClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOposClose_MouseClick);
            // 
            // checkDeviceEnabled
            // 
            this.checkDeviceEnabled.AutoSize = true;
            this.checkDeviceEnabled.Enabled = false;
            this.checkDeviceEnabled.Location = new System.Drawing.Point(173, 32);
            this.checkDeviceEnabled.Name = "checkDeviceEnabled";
            this.checkDeviceEnabled.Size = new System.Drawing.Size(121, 21);
            this.checkDeviceEnabled.TabIndex = 3;
            this.checkDeviceEnabled.Text = "Enable Device";
            this.checkDeviceEnabled.UseVisualStyleBackColor = true;
            this.checkDeviceEnabled.CheckedChanged += new System.EventHandler(this.checkDeviceEnabled_CheckedChanged);
            // 
            // btnOposRelease
            // 
            this.btnOposRelease.Enabled = false;
            this.btnOposRelease.Location = new System.Drawing.Point(87, 62);
            this.btnOposRelease.Name = "btnOposRelease";
            this.btnOposRelease.Size = new System.Drawing.Size(75, 27);
            this.btnOposRelease.TabIndex = 4;
            this.btnOposRelease.Text = "Release";
            this.btnOposRelease.UseVisualStyleBackColor = true;
            this.btnOposRelease.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOposRelease_MouseClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(6, 150);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(137, 34);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open Drawer";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOpen_MouseClick);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(48, 257);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(740, 181);
            this.logBox.TabIndex = 6;
            this.logBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOposOpen);
            this.groupBox1.Controls.Add(this.btnOposClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnOposClaim);
            this.groupBox1.Controls.Add(this.checkDeviceEnabled);
            this.groupBox1.Controls.Add(this.btnOposRelease);
            this.groupBox1.Location = new System.Drawing.Point(48, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Drawer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrtOpen);
            this.groupBox2.Controls.Add(this.btnPrtClose);
            this.groupBox2.Controls.Add(this.btnPrtClaim);
            this.groupBox2.Controls.Add(this.checkPrtEnabled);
            this.groupBox2.Controls.Add(this.btnPrtRelease);
            this.groupBox2.Location = new System.Drawing.Point(413, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printer";
            // 
            // btnPrtOpen
            // 
            this.btnPrtOpen.Location = new System.Drawing.Point(16, 32);
            this.btnPrtOpen.Name = "btnPrtOpen";
            this.btnPrtOpen.Size = new System.Drawing.Size(75, 29);
            this.btnPrtOpen.TabIndex = 5;
            this.btnPrtOpen.Text = "Open";
            this.btnPrtOpen.UseVisualStyleBackColor = true;
            this.btnPrtOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrtOpen_MouseClick);
            // 
            // btnPrtClose
            // 
            this.btnPrtClose.Enabled = false;
            this.btnPrtClose.Location = new System.Drawing.Point(16, 67);
            this.btnPrtClose.Name = "btnPrtClose";
            this.btnPrtClose.Size = new System.Drawing.Size(75, 27);
            this.btnPrtClose.TabIndex = 7;
            this.btnPrtClose.Text = "Close";
            this.btnPrtClose.UseVisualStyleBackColor = true;
            this.btnPrtClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrtClose_MouseClick);
            // 
            // btnPrtClaim
            // 
            this.btnPrtClaim.Enabled = false;
            this.btnPrtClaim.Location = new System.Drawing.Point(97, 32);
            this.btnPrtClaim.Name = "btnPrtClaim";
            this.btnPrtClaim.Size = new System.Drawing.Size(75, 29);
            this.btnPrtClaim.TabIndex = 6;
            this.btnPrtClaim.Text = "Claim";
            this.btnPrtClaim.UseVisualStyleBackColor = true;
            this.btnPrtClaim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrtClaim_MouseClick);
            // 
            // checkPrtEnabled
            // 
            this.checkPrtEnabled.AutoSize = true;
            this.checkPrtEnabled.Enabled = false;
            this.checkPrtEnabled.Location = new System.Drawing.Point(183, 37);
            this.checkPrtEnabled.Name = "checkPrtEnabled";
            this.checkPrtEnabled.Size = new System.Drawing.Size(121, 21);
            this.checkPrtEnabled.TabIndex = 8;
            this.checkPrtEnabled.Text = "Enable Device";
            this.checkPrtEnabled.UseVisualStyleBackColor = true;
            this.checkPrtEnabled.CheckedChanged += new System.EventHandler(this.checkPrtEnabled_CheckedChanged);
            // 
            // btnPrtRelease
            // 
            this.btnPrtRelease.Enabled = false;
            this.btnPrtRelease.Location = new System.Drawing.Point(97, 67);
            this.btnPrtRelease.Name = "btnPrtRelease";
            this.btnPrtRelease.Size = new System.Drawing.Size(75, 27);
            this.btnPrtRelease.TabIndex = 9;
            this.btnPrtRelease.Text = "Release";
            this.btnPrtRelease.UseVisualStyleBackColor = true;
            this.btnPrtRelease.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrtRelease_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOposOpen;
        private System.Windows.Forms.Button btnOposClaim;
        private System.Windows.Forms.Button btnOposClose;
        private System.Windows.Forms.CheckBox checkDeviceEnabled;
        private System.Windows.Forms.Button btnOposRelease;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrtOpen;
        private System.Windows.Forms.Button btnPrtClose;
        private System.Windows.Forms.Button btnPrtClaim;
        private System.Windows.Forms.CheckBox checkPrtEnabled;
        private System.Windows.Forms.Button btnPrtRelease;
    }
}

