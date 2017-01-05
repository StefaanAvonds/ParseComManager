using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class ScheduleParseTable : BaseParseTable<Schedule>
    {
        public ScheduleParseTable()
            : base(ParseTableNames.Schedule)
        {

        }

        /// <summary>
        /// Select all Schedule-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Schedule>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Schedule.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Schedule>();
            foreach (var record in records)
            {
                result.Add(new Schedule(record));
            }
            return result;
        }
    }
}
