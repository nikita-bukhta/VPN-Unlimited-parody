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
        protected struct Settings
        {
            public string installDir;
            public string appName;

            public bool desktopShortcut;
        }

        static protected readonly System.Windows.Forms.Form[] _allTabs = {
            new LicenseAgreementForm(),
            new InstallLocationForm(),
            new InstallShortcutLocationForm(),
            new AdditionalTaskForm(),
            new ConclusionForm()
        };
        static protected byte _currentTabNumber = 0;

        static protected Settings _settings = new Settings();

        public StandartWindow()
        {
            InitializeComponent();
        }
        
        // Before we close the window, ask customer, if he/she really want it;
        private protected void cancelButton_Click(object sender, EventArgs e)
        {
            string warningMessage = "Setun is not complete.If you exit now, the program will not be installed.\n\n" +
                "You may run Setup again at another time to complete the installation.\n\nExit Setup?";

            var result = MessageBox.Show(warningMessage, "Exit Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private protected void OpenNextWindow(StandartWindow newWindow) => newWindow.Show();

        private protected void backButton_Click(object sender, EventArgs e) 
        { 
            if (_currentTabNumber > 0)
            {
                this.Hide();
                _allTabs[--_currentTabNumber].Show();
            }
        }

        private protected void nextButton_Click(object sender, EventArgs e) 
        {
            if ((_currentTabNumber + 1) < _allTabs.Length)
            {
                this.Hide();
                _allTabs[++_currentTabNumber].Show();
            }
        }

        private void StandartWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
