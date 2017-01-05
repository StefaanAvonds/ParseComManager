# ParseComManager

With this application you can view your tables on a Parse.com-server.

## How does the application work?
First you will need to set the configuration-values to connect to a specific Parse.com-server. Once your application starts, it will check in your local application data-folder (%LocalAppData%) for the right XML-file; if no such file exists the application is unusable until valid values are entered.

```
<?xml version="1.0" encoding="utf-8"?>
<Configurations>
  <Configuration>
    <Server>[INSERT SERVER HERE]</Server>
    <ApplicationId>[INSERT APPLICATION ID HERE]</ApplicationId>
    <WindowsKey>[INSERT WINDOWS KEY HERE]</WindowsKey>
  </Configuration>
</Configurations>
```

Once the configuration-values are valid you can enter the application!

For now an example has been added to view login-records from a specific Parse.com-server.

## How to make your own tables visible?
Ofcourse it all starts with the right configuration-values.

### Data-scheme
Once you can connect to a specific Parse.com-server you will need to add a new class containing your table-scheme in folder "DataModels". Be sure to inherit from the interface **IDataModel**.
*Tip: create a second constructor to convert a ParseObject to your class.*
```C#
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
```

Next you will need to add a new enumeration-value to **ParseTableNames** located in folder "Parse".
```C#
namespace ParseComManager.Parse
{
    public enum ParseTableNames
    {
        Login
    }
}
```

Also a new Table-class is needed. This will contact the Parse.com-server and select records from the table. This class must be added in folder "Parse\Tables".
Always inherit from the class **BaseParseTable**! This base needs a generic type of IDataModel so we can use our newly made class.
Add as many queries as you need to this Table-class.

```C#
namespace ParseComManager.Parse.Tables
{
    public class LoginParseTable : BaseParseTable<Login>
    {
        public LoginParseTable()
            : base(ParseTableNames.Login)
        {

        }

        /// <summary>
        /// Select all login-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Login>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Login.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Login>();
            foreach (var record in records)
            {
                try
                {
                    result.Add(new Login(record));
                }
                catch { }
            }
            return result;
        }
    }
}
```

And that's it! Nothing more is needed to fetch data from the Parse.com-server.

### Show data in UI
The data can be read from a Parse.com-server, but it also needs to show up to the user in the UI.

To do this add a new Form to the application in the folder "Forms". Inherit the base class **FormView** that expects a generic type of IDataModel; use the class that you have added in the first step.
Now all you need to do to show all your data is override the method **DoRefreshDataSource**.

```C#
protected override Task<List<Login>> DoRefreshDataSource()
{
    return App.ParseManager.LoginTable.SelectAll();
}
```

Once this page shows up, every record in your table will be read from Parse.com and will be shown in a DataGridView.

## Extra
Please contact me if you have any questions or if you want some extra functionalities!
