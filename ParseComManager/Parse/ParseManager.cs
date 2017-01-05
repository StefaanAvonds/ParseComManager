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
        private CalendarParseTable _calendarTable;
        private ContactParseTable _contactTable;
        private GroupsParseTable _groupsTable;
        private HolidayParseTable _holidayTable;
        private HorseContactParseTable _horseContactTable;
        private HorseParseTable _horseTable;
        private LoginParseTable _loginTable;
        private ScheduleParseTable _scheduleTable;
        private SettingsParseTable _settingsTable;
        private TasksParseTable _tasksTable;

        /// <summary>
        /// The Parse.com-table for every calendar-record.
        /// </summary>
        public CalendarParseTable CalendarTable
        {
            get
            {
                if (_calendarTable == null) _calendarTable = new CalendarParseTable();
                return _calendarTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every contact-record.
        /// </summary>
        public ContactParseTable ContactTable
        {
            get
            {
                if (_contactTable == null) _contactTable = new ContactParseTable();
                return _contactTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every groups-record.
        /// </summary>
        public GroupsParseTable GroupsTable
        {
            get
            {
                if (_groupsTable == null) _groupsTable = new GroupsParseTable();
                return _groupsTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every holiday-record.
        /// </summary>
        public HolidayParseTable HolidayTable
        {
            get
            {
                if (_holidayTable == null) _holidayTable = new HolidayParseTable();
                return _holidayTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every horse-contact-record.
        /// </summary>
        public HorseContactParseTable HorseContactTable
        {
            get
            {
                if (_horseContactTable == null) _horseContactTable = new HorseContactParseTable();
                return _horseContactTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every horse-record.
        /// </summary>
        public HorseParseTable HorseTable
        {
            get
            {
                if (_horseTable == null) _horseTable = new HorseParseTable();
                return _horseTable;
            }
        }

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
        /// The Parse.com-table for every schedule-record.
        /// </summary>
        public ScheduleParseTable ScheduleTable
        {
            get
            {
                if (_scheduleTable == null) _scheduleTable = new ScheduleParseTable();
                return _scheduleTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every settings-record.
        /// </summary>
        public SettingsParseTable SettingsTable
        {
            get
            {
                if (_settingsTable == null) _settingsTable = new SettingsParseTable();
                return _settingsTable;
            }
        }

        /// <summary>
        /// The Parse.com-table for every tasks-record.
        /// </summary>
        public TasksParseTable TasksTable
        {
            get
            {
                if (_tasksTable == null) _tasksTable = new TasksParseTable();
                return _tasksTable;
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
