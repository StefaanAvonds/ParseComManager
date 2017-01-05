using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class GroupsParseTable : BaseParseTable<Groups>
    {
        public GroupsParseTable()
            : base(ParseTableNames.Groups)
        {

        }

        /// <summary>
        /// Select all Groups-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Groups>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Groups.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Groups>();
            foreach (var record in records)
            {
                result.Add(new Groups(record));
            }
            return result;
        }
    }
}
