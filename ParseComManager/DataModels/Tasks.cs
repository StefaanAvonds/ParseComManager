using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Tasks : IDataModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public Boolean Done { get; set; }
        public string DoneBy { get; set; }
        public DateTime? Date { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime? LastModified { get; set; }
        public String UserAttachedToTask { get; set; }

        public Tasks()
        {
            Id = 0;
            UserId = 0;
            Description = String.Empty;
            Done = false;
            DoneBy = String.Empty;
            Deleted = false;
            UserAttachedToTask = String.Empty;
        }

        public Tasks(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            int userId;
            parseObject.TryGetValue(nameof(UserId), out userId);
            UserId = userId;

            string description;
            parseObject.TryGetValue(nameof(Description), out description);
            Description = description;

            bool done;
            parseObject.TryGetValue(nameof(Done), out done);
            Done = done;

            string doneBy;
            parseObject.TryGetValue(nameof(DoneBy), out doneBy);
            DoneBy = doneBy;

            DateTime? date;
            parseObject.TryGetValue(nameof(Date), out date);
            Date = date;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;

            string userAttachedToTask;
            parseObject.TryGetValue(nameof(UserAttachedToTask), out userAttachedToTask);
            UserAttachedToTask = userAttachedToTask;
        }
    }
}
