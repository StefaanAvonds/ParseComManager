using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Contact : IDataModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public string Remarks { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime? LastModified { get; set; }
        
        public Contact()
        {
            Id = 0;
            Type = String.Empty;
            Name = String.Empty;
            Phone = String.Empty;
            Mobile = String.Empty;
            Mail = String.Empty;
            Remarks = String.Empty;
            Deleted = false;
        }

        public Contact(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            string type;
            parseObject.TryGetValue(nameof(Type), out type);
            Type = type;

            string name;
            parseObject.TryGetValue(nameof(Name), out name);
            Name = name;

            string phone;
            parseObject.TryGetValue(nameof(Phone), out phone);
            Phone = phone;

            string mobile;
            parseObject.TryGetValue(nameof(Mobile), out mobile);
            Mobile = mobile;

            string mail;
            parseObject.TryGetValue(nameof(Mail), out mail);
            Mail = mail;

            string remarks;
            parseObject.TryGetValue(nameof(Remarks), out remarks);
            Remarks = remarks;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;
        }
    }
}
