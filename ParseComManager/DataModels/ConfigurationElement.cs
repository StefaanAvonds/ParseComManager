using System;

namespace ParseComManager.DataModels
{
    /// <summary>
    /// The element that contains the different values to connect to a Parse.com-database.
    /// </summary>
    public class ConfigurationElement
    {
        /// <summary>
        /// The Parse.com-server.
        /// </summary>
        public String Server { get; set; }
        /// <summary>
        /// The Application ID in Parse.com.
        /// </summary>
        public String ApplicationId { get; set; }
        /// <summary>
        /// The Windows key in Parse.com.
        /// </summary>
        public String WindowsKey { get; set; }

        /// <summary>
        /// The default value of "Server". This will be the value in the configuration file on first use of the application.
        /// </summary>
        public static String DefaultServerValue = "[INSERT SERVER HERE]";
        /// <summary>
        /// The default value of "ApplicationId". This will be the value in the configuration file on first use of the application.
        /// </summary>
        public static String DefaultApplicationIdValue = "[INSERT APPLICATION ID HERE]";
        /// <summary>
        /// The default value of "WindowsKey". This will be the value in the configuration file on first use of the application.
        /// </summary>
        public static String DefaultWindowsKeyValue = "[INSERT WINDOWS KEY HERE]";

        /// <summary>
        /// The element that contains the different values to connect to a Parse.com-database.
        /// </summary>
        public ConfigurationElement()
        {
            Server = DefaultServerValue;
            ApplicationId = DefaultApplicationIdValue;
            WindowsKey = DefaultWindowsKeyValue;
        }

        /// <summary>
        /// The element that contains the different values to connect to a Parse.com-database.
        /// </summary>
        /// <param name="server">Value for "Server".</param>
        /// <param name="applicationId">Value for "ApplicationId".</param>
        /// <param name="windowsKey">Value for "WindowsKey".</param>
        public ConfigurationElement(string server, string applicationId, string windowsKey)
            : this()
        {
            Server = server;
            ApplicationId = applicationId;
            WindowsKey = windowsKey;
        }
    }
}
