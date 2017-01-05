using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class HolidayParseTable : BaseParseTable<Holiday>
    {
        public HolidayParseTable()
            : base(ParseTableNames.Holiday)
        {

        }

        /// <summary>
        /// Select all Holiday-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Holiday>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Holiday.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Holiday>();
            foreach (var record in records)
            {
                result.Add(new Holiday(record));
            }
            return result;
        }
    }
}
