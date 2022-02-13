using System.IO; 

namespace VPN_Unlimited_parody
{
    partial class StandartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandartWindow));
            this.mainIco = new System.Windows.Forms.PictureBox();
            this.simpleWhitePanel = new System.Windows.Forms.Panel();
            this.tabDescriptionLabel = new System.Windows.Forms.Label();
            this.tabTitleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainIco)).BeginInit();
            this.simpleWhitePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainIco
            // 
            this.mainIco.Image = global::VPN_Unlimited_parody.Properties.Resources.logo;
            this.mainIco.Location = new System.Drawing.Point(425, 0);
            this.mainIco.Name = "mainIco";
            this.mainIco.Size = new System.Drawing.Size(65, 65);
            this.mainIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainIco.TabIndex = 0;
            this.mainIco.TabStop = false;
            // 
            // simpleWhitePanel
            // 
            this.simpleWhitePanel.BackColor = System.Drawing.Color.White;
            this.simpleWhitePanel.Controls.Add(this.tabDescriptionLabel);
            this.simpleWhitePanel.Controls.Add(this.tabTitleLabel);
            this.simpleWhitePanel.Controls.Add(this.mainIco);
            this.simpleWhitePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleWhitePanel.Location = new System.Drawing.Point(0, 0);
            this.simpleWhitePanel.Name = "simpleWhitePanel";
            this.simpleWhitePanel.Size = new System.Drawing.Size(484, 65);
            this.simpleWhitePanel.TabIndex = 1;
            // 
            // tabDescriptionLabel
            // 
            this.tabDescriptionLabel.AutoSize = true;
            this.tabDescriptionLabel.Location = new System.Drawing.Point(31, 30);
            this.tabDescriptionLabel.Name = "tabDescriptionLabel";
            this.tabDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.tabDescriptionLabel.TabIndex = 2;
            this.tabDescriptionLabel.Text = "Tab description";
            // 
            // tabTitleLabel
            // 
            this.tabTitleLabel.AutoSize = true;
            this.tabTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.tabTitleLabel.Name = "tabTitleLabel";
            this.tabTitleLabel.Size = new System.Drawing.Size(54, 13);
            this.tabTitleLabel.TabIndex = 1;
            this.tabTitleLabel.Text = "Tab title";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 316);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(307, 316);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(226, 316);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // StandartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.simpleWhitePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StandartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup - VPN Unlimited";
            ((System.ComponentModel.ISupportInitialize)(this.mainIco)).EndInit();
            this.simpleWhitePanel.ResumeLayout(false);
            this.simpleWhitePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainIco;
        private System.Windows.Forms.Panel simpleWhitePanel;
        protected System.Windows.Forms.Button cancelButton;
        protected System.Windows.Forms.Button nextButton;
        protected System.Windows.Forms.Button backButton;
        protected System.Windows.Forms.Label tabDescriptionLabel;
        protected System.Windows.Forms.Label tabTitleLabel;
    }
}

