
namespace VPN_Unlimited_parody
{
    partial class InstallLocationForm
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
            this.chooseInstallLocationButton = new System.Windows.Forms.Button();
            this.browseLinkBox = new System.Windows.Forms.TextBox();
            this.someNiceImg = new System.Windows.Forms.PictureBox();
            this.warningSetupLabel = new System.Windows.Forms.Label();
            this.informToChooseDirLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.someNiceImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDescriptionLabel
            // 
            this.tabDescriptionLabel.Size = new System.Drawing.Size(200, 13);
            this.tabDescriptionLabel.Text = "Where should VPN Unlimited be installed";
            // 
            // tabTitleLabel
            // 
            this.tabTitleLabel.Size = new System.Drawing.Size(164, 13);
            this.tabTitleLabel.Text = "Select Destination Location";
            // 
            // chooseInstallLocationButton
            // 
            this.chooseInstallLocationButton.Location = new System.Drawing.Point(385, 137);
            this.chooseInstallLocationButton.Name = "chooseInstallLocationButton";
            this.chooseInstallLocationButton.Size = new System.Drawing.Size(75, 23);
            this.chooseInstallLocationButton.TabIndex = 5;
            this.chooseInstallLocationButton.Text = "Browse...";
            this.chooseInstallLocationButton.UseVisualStyleBackColor = true;
            this.chooseInstallLocationButton.Click += new System.EventHandler(this.chooseInstallLocationButton_Click);
            // 
            // browseLinkBox
            // 
            this.browseLinkBox.Location = new System.Drawing.Point(30, 140);
            this.browseLinkBox.Name = "browseLinkBox";
            this.browseLinkBox.Size = new System.Drawing.Size(352, 20);
            this.browseLinkBox.TabIndex = 6;
            this.browseLinkBox.Text = "C:\\Program Files (x86)\\VPN Unlimited";
            _settings.installDir = this.browseLinkBox.Text;
            // 
            // someNiceImg
            // 
            this.someNiceImg.Image = global::VPN_Unlimited_parody.Properties.Resources.folder;
            this.someNiceImg.Location = new System.Drawing.Point(30, 71);
            this.someNiceImg.Name = "someNiceImg";
            this.someNiceImg.Size = new System.Drawing.Size(40, 40);
            this.someNiceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.someNiceImg.TabIndex = 7;
            this.someNiceImg.TabStop = false;
            // 
            // warningSetupLabel
            // 
            this.warningSetupLabel.AutoSize = true;
            this.warningSetupLabel.Location = new System.Drawing.Point(76, 86);
            this.warningSetupLabel.Name = "warningSetupLabel";
            this.warningSetupLabel.Size = new System.Drawing.Size(258, 13);
            this.warningSetupLabel.TabIndex = 8;
            this.warningSetupLabel.Text = "Setup will install VPN Inlimited into the following folder";
            this.warningSetupLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // informToChooseDirLabel
            // 
            this.informToChooseDirLabel.AutoSize = true;
            this.informToChooseDirLabel.Location = new System.Drawing.Point(31, 114);
            this.informToChooseDirLabel.Name = "informToChooseDirLabel";
            this.informToChooseDirLabel.Size = new System.Drawing.Size(390, 13);
            this.informToChooseDirLabel.TabIndex = 9;
            this.informToChooseDirLabel.Text = "To continue, click Next. If you would like to select a different folder, click Br" +
    "owse.";
            // 
            // InstallLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.informToChooseDirLabel);
            this.Controls.Add(this.warningSetupLabel);
            this.Controls.Add(this.someNiceImg);
            this.Controls.Add(this.browseLinkBox);
            this.Controls.Add(this.chooseInstallLocationButton);
            this.Name = "InstallLocationForm";
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.chooseInstallLocationButton, 0);
            this.Controls.SetChildIndex(this.browseLinkBox, 0);
            this.Controls.SetChildIndex(this.someNiceImg, 0);
            this.Controls.SetChildIndex(this.warningSetupLabel, 0);
            this.Controls.SetChildIndex(this.informToChooseDirLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.someNiceImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chooseInstallLocationButton;
        protected System.Windows.Forms.TextBox browseLinkBox;
        protected System.Windows.Forms.PictureBox someNiceImg;
        protected System.Windows.Forms.Label warningSetupLabel;
        protected System.Windows.Forms.Label informToChooseDirLabel;
    }
}