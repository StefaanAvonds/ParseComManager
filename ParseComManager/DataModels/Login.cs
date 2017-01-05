using Parse;
using ParseComManager.Interfaces;
using System;

namespace ParseComManager.DataModels
{
    public class Login : IDataModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public Boolean Deleted { get; set; }
        public Boolean Admin { get; set; }
        public DateTime? LastModified { get; set; }

        public Login()
        {
            Id = 0;
            Username = String.Empty;
            Password = String.Empty;
            FullName = String.Empty;
            Deleted = false;
            Admin = false;
        }

        public Login(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            string username;
            parseObject.TryGetValue(nameof(Username), out username);
            Username = username;

            string password;
            parseObject.TryGetValue(nameof(Password), out password);
            Password = password;

            string fullName;
            parseObject.TryGetValue(nameof(FullName), out fullName);
            FullName = fullName;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            bool admin;
            parseObject.TryGetValue(nameof(Admin), out admin);
            Admin = admin;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;
        }
    }
}
