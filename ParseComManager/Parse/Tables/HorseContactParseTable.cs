using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class HorseContactParseTable : BaseParseTable<HorseContact>
    {
        public HorseContactParseTable()
            : base(ParseTableNames.HorseContact)
        {

        }

        /// <summary>
        /// Select all HorseContact-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<HorseContact>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(HorseContact.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<HorseContact>();
            foreach (var record in records)
            {
                result.Add(new HorseContact(record));
            }
            return result;
        }
    }
}
