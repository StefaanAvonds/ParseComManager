using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Schedule : IDataModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }
        //Not sure if the StartHoure and EndHour should be DateTime, string, ... ?
        public DateTime? StartHour { get; set; }
        public DateTime? EndHour { get; set; }
        //WorkedHours should be calculated by checking the difference from starthour against endhour.
        public int WorkedHours { get; set; }
        public Boolean Deleted { get; set; }
        public string Remarks { get; set; }
        public DateTime? LastModified { get; set; }
        public Boolean? DayOff { get; set; }
        public Boolean? FullDay { get; set; }

        public Schedule()
        {
            Id = 0;
            UserId = 0;
            WorkedHours = 0;
            Deleted = false;
            Remarks = String.Empty;
        }

        public Schedule(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            int userId;
            parseObject.TryGetValue(nameof(UserId), out userId);
            UserId = userId;

            DateTime? date;
            parseObject.TryGetValue(nameof(Date), out date);
            Date = date;

            DateTime? startHour;
            parseObject.TryGetValue(nameof(StartHour), out startHour);
            StartHour = startHour;

            DateTime? endHour;
            parseObject.TryGetValue(nameof(EndHour), out endHour);
            EndHour = endHour;

            int workedHours;
            parseObject.TryGetValue(nameof(WorkedHours), out workedHours);
            WorkedHours = workedHours;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            string remarks;
            parseObject.TryGetValue(nameof(Remarks), out remarks);
            Remarks = remarks;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;

            bool? dayOff;
            parseObject.TryGetValue(nameof(DayOff), out dayOff);
            DayOff = dayOff;

            bool? fullDay;
            parseObject.TryGetValue(nameof(FullDay), out fullDay);
            FullDay = fullDay;
        }
    }
}
