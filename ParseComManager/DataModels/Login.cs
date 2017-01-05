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
            Id = parseObject.Get<int>(nameof(Id));
            Username = parseObject.Get<string>(nameof(Username));
            Password = parseObject.Get<string>(nameof(Password));
            FullName = parseObject.Get<string>(nameof(FullName));
            Deleted = parseObject.Get<bool>(nameof(Deleted));
            Admin = parseObject.Get<bool>(nameof(Admin));
            LastModified = parseObject.Get<DateTime?>(nameof(LastModified));
        }
    }
}
