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
    public partial class StandartWindow : Form
    {
        public StandartWindow()
        {
            InitializeComponent();
        }
        
        // Before we close the window, ask customer, if he/she really want it;
        private protected virtual void cancelButton_Click(object sender, EventArgs e)
        {
            string warningMessage = "Setun is not complete.If you exit now, the program will not be installed.\n\n" +
                "You may run Setup again at another time to complete the installation.\n\nExit Setup?";

            var result = MessageBox.Show(warningMessage, "Exit Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private protected virtual void nextButton_Click(object sender, EventArgs e) { }

        private protected virtual void backButton_Click(object sender, EventArgs e) { }
    }
}
