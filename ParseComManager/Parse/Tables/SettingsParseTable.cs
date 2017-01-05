using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class SettingsParseTable : BaseParseTable<Settings>
    {
        public SettingsParseTable()
            : base(ParseTableNames.Settings)
        {

        }

        /// <summary>
        /// Select all Settings-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Settings>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Settings.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Settings>();
            foreach (var record in records)
            {
                result.Add(new Settings(record));
            }
            return result;
        }
    }
}
