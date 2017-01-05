using Parse;
using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.Parse.Tables
{
    public class ContactParseTable : BaseParseTable<Contact>
    {
        public ContactParseTable()
            : base(ParseTableNames.Contact)
        {

        }

        /// <summary>
        /// Select all Contact-records from Parse.com.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Contact>> SelectAll()
        {
            var query = from table in ParseObject.GetQuery(TableName.ToString())
                        orderby table.Get<int>(nameof(Contact.Id))
                        select table;

            var records = await query.FindAsync();

            var result = new List<Contact>();
            foreach (var record in records)
            {
                result.Add(new Contact(record));
            }
            return result;
        }
    }
}
