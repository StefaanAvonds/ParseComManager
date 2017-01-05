using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Calendar : IDataModel
    {
        public int Id { get; set; }
        public int HorseId { get; set; }
        public string Type { get; set; }
        public int ContactId { get; set; }
        public string Remarks { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastModified { get; set; }
        public string ContactName { get; set; }
        public string HorseName { get; set; }

        public Calendar()
        {
            Id = 0;
            HorseId = 0;
            Type = String.Empty;
            ContactId = 0;
            Remarks = String.Empty;
            Deleted = false;
            ContactName = String.Empty;
            HorseName = String.Empty;
        }

        public Calendar(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(id), out id);
            Id = id;

            int horseId;
            parseObject.TryGetValue(nameof(HorseId), out horseId);
            HorseId = horseId;

            string type;
            parseObject.TryGetValue(nameof(Type), out type);
            Type = type;

            int contactId;
            parseObject.TryGetValue(nameof(ContactId), out contactId);
            ContactId = contactId;

            string remarks;
            parseObject.TryGetValue(nameof(Remarks), out remarks);
            Remarks = remarks;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            DateTime? startDate;
            parseObject.TryGetValue(nameof(StartDate), out startDate);
            StartDate = startDate;

            DateTime? endDate;
            parseObject.TryGetValue(nameof(EndDate), out endDate);
            EndDate = endDate;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;

            string contactName;
            parseObject.TryGetValue(nameof(ContactName), out contactName);
            ContactName = contactName;

            string horseName;
            parseObject.TryGetValue(nameof(HorseName), out horseName);
            HorseName = horseName;
        }
    }
}
