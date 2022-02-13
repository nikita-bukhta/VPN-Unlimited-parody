
namespace VPN_Unlimited_parody
{
    partial class LicenseAgreementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseAgreementForm));
            this.licenseAgreementBox = new System.Windows.Forms.TextBox();
            this.pleaseLabel = new System.Windows.Forms.Label();
            this.agreeRB = new System.Windows.Forms.RadioButton();
            this.disagreeRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tabDescriptionLabel
            // 
            this.tabDescriptionLabel.Size = new System.Drawing.Size(313, 13);
            this.tabDescriptionLabel.Text = "Please read the following important information before continuing.";
            // 
            // tabTitleLabel
            // 
            this.tabTitleLabel.Size = new System.Drawing.Size(115, 13);
            this.tabTitleLabel.Text = "License Agreement";
            // 
            // licenseAgreementBox
            // 
            this.licenseAgreementBox.Location = new System.Drawing.Point(40, 110);
            this.licenseAgreementBox.Multiline = true;
            this.licenseAgreementBox.Name = "licenseAgreementBox";
            this.licenseAgreementBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licenseAgreementBox.Size = new System.Drawing.Size(400, 150);
            this.licenseAgreementBox.TabIndex = 2;
            this.licenseAgreementBox.Text = resources.GetString("licenseAgreementBox.Text");
            // 
            // pleaseLabel
            // 
            this.pleaseLabel.Location = new System.Drawing.Point(40, 73);
            this.pleaseLabel.Name = "pleaseLabel";
            this.pleaseLabel.Size = new System.Drawing.Size(400, 34);
            this.pleaseLabel.TabIndex = 3;
            this.pleaseLabel.Text = "Please read tge following Agreemnt. You must accept the term of this agreement be" +
    "fore continuing with the installation.";
            // 
            // agreeRB
            // 
            this.agreeRB.AutoSize = true;
            this.agreeRB.Checked = true;
            this.agreeRB.Location = new System.Drawing.Point(40, 266);
            this.agreeRB.Name = "agreeRB";
            this.agreeRB.Size = new System.Drawing.Size(135, 17);
            this.agreeRB.TabIndex = 4;
            this.agreeRB.TabStop = true;
            this.agreeRB.Text = "I accept the agreement";
            this.agreeRB.UseVisualStyleBackColor = true;
            this.agreeRB.CheckedChanged += new System.EventHandler(this.agreeRB_CheckedChanged);
            // 
            // disagreeRB
            // 
            this.disagreeRB.AutoSize = true;
            this.disagreeRB.Location = new System.Drawing.Point(40, 289);
            this.disagreeRB.Name = "disagreeRB";
            this.disagreeRB.Size = new System.Drawing.Size(168, 17);
            this.disagreeRB.TabIndex = 5;
            this.disagreeRB.Text = "I do not accept the agreement";
            this.disagreeRB.UseVisualStyleBackColor = true;
            this.disagreeRB.CheckedChanged += new System.EventHandler(this.disagreeRB_CheckedChanged);
            // 
            // LicenseAgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.disagreeRB);
            this.Controls.Add(this.agreeRB);
            this.Controls.Add(this.pleaseLabel);
            this.Controls.Add(this.licenseAgreementBox);
            this.Name = "LicenseAgreementForm";
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.licenseAgreementBox, 0);
            this.Controls.SetChildIndex(this.pleaseLabel, 0);
            this.Controls.SetChildIndex(this.agreeRB, 0);
            this.Controls.SetChildIndex(this.disagreeRB, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox licenseAgreementBox;
        private System.Windows.Forms.Label pleaseLabel;
        private System.Windows.Forms.RadioButton agreeRB;
        private System.Windows.Forms.RadioButton disagreeRB;
    }
}