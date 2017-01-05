using ParseComManager.DataModels;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ParseComManager.Managers
{
    /// <summary>
    /// Manager for the local configuration file.
    /// </summary>
    public class LocalConfigurationFile
    {
        private const string Filename = "ParseComManagerConfiguration.xml";

        private string _filePath;

        private XDocument _xmlDocument;

        /// <summary>
        /// Manager for the local configuration file.
        /// </summary>
        public LocalConfigurationFile()
        {
            _filePath = GetConfigurationFilePath();

            if (!File.Exists(_filePath))
            {
                _xmlDocument = new XDocument();
                CreateDefaultConfigurationFile();
            }
            else
            {
                _xmlDocument = XDocument.Load(_filePath);
            }
        }

        /// <summary>
        /// Get the full path to the configuration file.
        /// </summary>
        /// <returns>The local file path.</returns>
        private string GetConfigurationFilePath()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string configurationFileDirectory = Path.Combine(localAppData, "ParseComManager");

            if (!Directory.Exists(configurationFileDirectory)) Directory.CreateDirectory(configurationFileDirectory);

            return Path.Combine(configurationFileDirectory, Filename);
        }

        /// <summary>
        /// Create the default XML-file with the default values for each configuration-element.
        /// </summary>
        private void CreateDefaultConfigurationFile()
        {
            XElement xml = new XElement("Configurations",
                CreateConfigurationElement(new ConfigurationElement()));

            _xmlDocument.Add(xml);
            _xmlDocument.Save(_filePath);
        }

        /// <summary>
        /// Create the XML-element that contains the needed values for the configuration.
        /// </summary>
        /// <param name="configurationElement">The different values for the configuration to Parse.com.</param>
        /// <returns>An XML-element.</returns>
        private XElement CreateConfigurationElement(ConfigurationElement configurationElement)
        {
            return CreateConfigurationElement(configurationElement.Server, configurationElement.ApplicationId, configurationElement.WindowsKey);
        }

        /// <summary>
        /// Create the XML-element that contains the needed values for the configuration.
        /// </summary>
        /// <param name="server">Value for the server.</param>
        /// <param name="applicationId">Value for the application ID.</param>
        /// <param name="windowsKey">Value for the Windows key.</param>
        /// <returns>An XML-element.</returns>
        private XElement CreateConfigurationElement(string server, string applicationId, string windowsKey)
        {
            return new XElement("Configuration",
                new XElement(nameof(ConfigurationElement.Server), server),
                new XElement(nameof(ConfigurationElement.ApplicationId), applicationId),
                new XElement(nameof(ConfigurationElement.WindowsKey), windowsKey));

        }

        /// <summary>
        /// Read the configuration.
        /// </summary>
        /// <returns>A configuration-element containing the different configuration-values.</returns>
        public ConfigurationElement ReadConfiguration()
        {
            var configurationElements = from xml in _xmlDocument.Descendants("Configuration")
                                        select new ConfigurationElement
                                        {
                                            Server = xml.Element(nameof(ConfigurationElement.Server)).Value,
                                            ApplicationId = xml.Element(nameof(ConfigurationElement.ApplicationId)).Value,
                                            WindowsKey = xml.Element(nameof(ConfigurationElement.WindowsKey)).Value
                                        };

            if (!configurationElements.Any()) return new ConfigurationElement();

            return configurationElements.FirstOrDefault();
        }
        
        /// <summary>
        /// Open the local configuration file.
        /// </summary>
        public void OpenConfigurationFile()
        {
            Process.Start(_filePath);
        }
    }
}
