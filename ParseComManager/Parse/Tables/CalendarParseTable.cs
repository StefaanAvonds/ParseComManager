using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class CalendarParseTable : BaseParseTable<Calendar>
    {
        public CalendarParseTable()
            : base(ParseTableNames.Calendar)
        {

        }

        /// <summary>
        /// Select all Calendar-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Calendar>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Calendar.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Calendar>();
            foreach (var record in records)
            {
                result.Add(new Calendar(record));
            }
            return result;
        }
    }
}
