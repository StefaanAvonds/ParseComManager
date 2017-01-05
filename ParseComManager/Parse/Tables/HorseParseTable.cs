using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class HorseParseTable : BaseParseTable<Horse>
    {
        public HorseParseTable()
            : base(ParseTableNames.Horse)
        {

        }

        /// <summary>
        /// Select all Horse-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Horse>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Horse.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Horse>();
            foreach (var record in records)
            {
                result.Add(new Horse(record));
            }
            return result;
        }
    }
}
