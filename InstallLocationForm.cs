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
    public partial class InstallLocationForm : StandartWindow
    {
        public InstallLocationForm() : base()
        {
            InitializeComponent();
        }

        private void chooseInstallLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog link = new FolderBrowserDialog();

            if (link.ShowDialog() == DialogResult.OK)
                browseLinkBox.Text = link.SelectedPath;
        }
    }
}
