using Parse;
using ParseComManager.Parse.Tables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse
{
    /// <summary>
    /// Class that must be used to access any Parse.com functionality.
    /// </summary>
    public class ParseManager
    {
        private LoginParseTable _loginTable;

        /// <summary>
        /// The Parse.com-table for every login-record.
        /// </summary>
        public LoginParseTable LoginTable
        {
            get
            {
                if (_loginTable == null) _loginTable = new LoginParseTable();
                return _loginTable;
            }
        }

        /// <summary>
        /// Class that must be used to access any Parse.com functionality.
        /// </summary>
        public ParseManager()
        {
            InitializeConfiguration();
        }

        /// <summary>
        /// Reads the configuration-values in the local configuration-file and initializes the connection to the Parse.com-server.
        /// </summary>
        private void InitializeConfiguration()
        {
            var configuration = new ParseClient.Configuration();
            if (!String.IsNullOrWhiteSpace(App.ConfigurationElement.Server)) configuration.Server = App.ConfigurationElement.Server;
            if (!String.IsNullOrWhiteSpace(App.ConfigurationElement.ApplicationId)) configuration.ApplicationId = App.ConfigurationElement.ApplicationId;
            if (!String.IsNullOrWhiteSpace(App.ConfigurationElement.WindowsKey)) configuration.WindowsKey = App.ConfigurationElement.WindowsKey;

            ParseClient.Initialize(configuration);
        }
    }
}
