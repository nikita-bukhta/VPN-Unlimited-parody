
namespace VPN_Unlimited_parody
{
    partial class InstallShortcutLocationForm
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
            ((System.ComponentModel.ISupportInitialize)(this.someNiceImg)).BeginInit();
            this.SuspendLayout();
            // 
            // browseLinkBox
            // 
            this.browseLinkBox.Text = "VPN Unlimited";
            _settings.appName = this.browseLinkBox.Text;
            // 
            // someNiceImg
            // 
            this.someNiceImg.Image = global::VPN_Unlimited_parody.Properties.Resources.shortcuts;
            // 
            // warningSetupLabel
            // 
            this.warningSetupLabel.Size = new System.Drawing.Size(356, 13);
            this.warningSetupLabel.Text = "Setup will create the program\'s shortcuts in the following Start Meny folder.";
            // 
            // tabDescriptionLabel
            // 
            this.tabDescriptionLabel.Size = new System.Drawing.Size(251, 13);
            this.tabDescriptionLabel.Text = "Where should Setup place the program\'s shortcuts?";
            // 
            // tabTitleLabel
            // 
            this.tabTitleLabel.Size = new System.Drawing.Size(148, 13);
            this.tabTitleLabel.Text = "Select Start Menu Folder";
            // 
            // InstallShortcutLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Name = "InstallShortcutLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.someNiceImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}