using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPN_Unlimited_parody
{
    public partial class LicenseAgreementForm : StandartWindow
    {
        public LicenseAgreementForm() : base() 
        {
            this.backButton.Hide();
            InitializeComponent();  
        }

        private void disagreeRB_CheckedChanged(object sender, EventArgs e) => this.nextButton.Enabled = false;

        private void agreeRB_CheckedChanged(object sender, EventArgs e) => this.nextButton.Enabled = true;
    }
}
