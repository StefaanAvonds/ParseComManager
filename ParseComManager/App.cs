using ParseComManager.DataModels;
using ParseComManager.Parse;

namespace ParseComManager
{
    /// <summary>
    /// Class that contains many different values that can be used throughout the entire application.
    /// </summary>
    public static class App
    {
        private static ParseManager _parseManager;

        private static ConfigurationElement _configurationElement;

        /// <summary>
        /// The Parse.com-manager.
        /// </summary>
        public static ParseManager ParseManager
        {
            get
            {
                if (_parseManager == null) _parseManager = new ParseManager();
                return _parseManager;
            }
        }

        /// <summary>
        /// The values for the configuration to Parse.com.
        /// </summary>
        public static ConfigurationElement ConfigurationElement
        {
            get { return _configurationElement; }
            set { _configurationElement = value; }
        }
    }
}
