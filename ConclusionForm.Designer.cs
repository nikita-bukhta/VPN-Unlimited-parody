
namespace VPN_Unlimited_parody
{
    partial class ConclusionForm
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
            this.conclusionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conclusionBox
            // 
            this.conclusionBox.Location = new System.Drawing.Point(16, 99);
            this.conclusionBox.Multiline = true;
            this.conclusionBox.Name = "conclusionBox";
            this.conclusionBox.Size = new System.Drawing.Size(442, 158);
            this.conclusionBox.TabIndex = 5;

            conclusionBox.Text = "Destination location:\n\t" + _settings.installDir +
                "\n\nStart menu folder:\n\t" + _settings.appName +
                "\n\nAdditional tasks:\n\tAdditional shortcuts:\n\t\t";

            if (_settings.desktopShortcut)
                conclusionBox.Text += "Create a desktop shortcut";
            else
                conclusionBox.Text += "Empty";
            // 
            // ConclusionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 351);
            this.Controls.Add(this.conclusionBox);
            this.Name = "ConclusionForm";
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.conclusionBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox conclusionBox;
    }
}