using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Holiday : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime? LastModified { get; set; }

        public Holiday()
        {
            Id = 0;
            Name = String.Empty;
            Deleted = false;
        }

        public Holiday(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            string name;
            parseObject.TryGetValue(nameof(Name), out name);
            Name = name;

            DateTime? date;
            parseObject.TryGetValue(nameof(Date), out date);
            Date = date;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;
        }
    }
}
