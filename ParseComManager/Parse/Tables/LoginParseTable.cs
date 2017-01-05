using Parse;
using ParseComManager.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
