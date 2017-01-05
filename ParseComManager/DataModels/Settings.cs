using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Settings : IDataModel
    {
        public int Id { get; set; }
        public DateTime Last_sync { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Boolean Admin { get; set; }
        public Boolean RememberCredentials { get; set; }
        public int LastSelectedHorse { get; set; }
        
        public Settings()
        {
            Id = 0;
            Last_sync = DateTime.MinValue;
            UserId = 0;
            Username = String.Empty;
            Password = String.Empty;
            Admin = false;
            RememberCredentials = false;
            LastSelectedHorse = 0;
        }

        public Settings(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            DateTime lastSync;
            parseObject.TryGetValue(nameof(Last_sync), out lastSync);
            Last_sync = lastSync;

            int userId;
            parseObject.TryGetValue(nameof(UserId), out userId);
            UserId = userId;

            string username;
            parseObject.TryGetValue(nameof(Username), out username);
            Username = username;

            string password;
            parseObject.TryGetValue(nameof(password), out password);
            Password = password;

            bool admin;
            parseObject.TryGetValue(nameof(Admin), out admin);
            Admin = admin;

            bool rememberCredentials;
            parseObject.TryGetValue(nameof(RememberCredentials), out rememberCredentials);
            RememberCredentials = rememberCredentials;

            int lastSelectedHorse;
            parseObject.TryGetValue(nameof(LastSelectedHorse), out lastSelectedHorse);
            LastSelectedHorse = lastSelectedHorse;
        }
    }
}
