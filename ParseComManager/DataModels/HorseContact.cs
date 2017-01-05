using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class HorseContact : IDataModel
    {
        public int Id { get; set; }
        public int HorseId { get; set; }
        public int ContactId { get; set; }
        public string Type { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime? LastModified { get; set; }
        //For referencing to table Contact
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Remarks { get; set; }
        public string Mail { get; set; }

        public HorseContact()
        {
            Id = 0;
            HorseId = 0;
            ContactId = 0;
            Type = String.Empty;
            Deleted = false;
            Name = String.Empty;
            Phone = String.Empty;
            Mobile = String.Empty;
            Remarks = String.Empty;
            Mail = String.Empty;
        }

        public HorseContact(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            int horseId;
            parseObject.TryGetValue(nameof(HorseId), out horseId);
            HorseId = horseId;

            int contactId;
            parseObject.TryGetValue(nameof(ContactId), out contactId);
            ContactId = contactId;

            string type;
            parseObject.TryGetValue(nameof(Type), out type);
            Type = type;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;

            string name;
            parseObject.TryGetValue(nameof(Name), out name);
            Name = name;

            string phone;
            parseObject.TryGetValue(nameof(Phone), out phone);
            Phone = phone;

            string mobile;
            parseObject.TryGetValue(nameof(Mobile), out mobile);
            Mobile = mobile;

            string remarks;
            parseObject.TryGetValue(nameof(Remarks), out remarks);
            Remarks = remarks;

            string mail;
            parseObject.TryGetValue(nameof(Mail), out mail);
            Mail = mail;
        }
    }
}
