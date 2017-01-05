using ParseComManager.DataModels;
using ParseComManager.Forms;
using ParseComManager.Managers;
using System;
using System.Windows.Forms;

namespace ParseComManager
{
    public partial class Homepage : Form
    {
        private LocalConfigurationFile _localConfigurationFile;

        public Homepage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            _localConfigurationFile = new LocalConfigurationFile();

            ConfigurationElement configurationElement;
            if (!IsConfigurationFileValid(out configurationElement))
            {
                // File is invalid
                MessageBox.Show("The configuration file is invalid. In order to use this application, please fill in the right values.", "Invalid configuration!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _localConfigurationFile.OpenConfigurationFile();
                CloseApplication();
            }
            else
            {
                App.ConfigurationElement = configurationElement;
            }
        }

        /// <summary>
        /// Checks if the local configuration file is valid.
        /// </summary>
        /// <param name="configurationElement">The element in the configuration file.</param>
        /// <returns>TRUE = configuration-file is valid and can be used | FALSE = configuration-file is invalid and cannot be used</returns>
        private bool IsConfigurationFileValid(out ConfigurationElement configurationElement)
        {
            configurationElement = _localConfigurationFile.ReadConfiguration();

            if (configurationElement.Server.Equals(ConfigurationElement.DefaultServerValue)) return false;
            if (configurationElement.ApplicationId.Equals(ConfigurationElement.DefaultApplicationIdValue)) return false;
            if (configurationElement.WindowsKey.Equals(ConfigurationElement.DefaultWindowsKeyValue)) return false;

            return true;
        }

        /// <summary>
        /// Close the application.
        /// </summary>
        private void CloseApplication()
        {
            Application.Exit();
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            var page = new FVLogins();
            page.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CloseApplication();
        }

        private void btnConfigurationFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The changes you make to the configuration file will not be updated in the application! Restart the application if you want to use the new settings.", "Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _localConfigurationFile.OpenConfigurationFile();
        }
    }
}
