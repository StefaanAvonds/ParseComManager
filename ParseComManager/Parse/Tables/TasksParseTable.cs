using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class TasksParseTable : BaseParseTable<Tasks>
    {
        public TasksParseTable()
            : base(ParseTableNames.Tasks)
        {

        }

        /// <summary>
        /// Select all Tasks-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tasks>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Tasks.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Tasks>();
            foreach (var record in records)
            {
                result.Add(new Tasks(record));
            }
            return result;
        }
    }
}
