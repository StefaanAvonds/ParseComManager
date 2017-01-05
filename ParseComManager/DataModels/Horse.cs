using Parse;
using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseComManager.DataModels
{
    public class Horse : IDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public string Birthyear { get; set; }
        public Boolean Deleted { get; set; }
        public Boolean IsChecked { get; set; } //This field is used for AddAppointmentFromCalendar to know which horse is selected.

        //[ForeignKey(typeof(Groups))]
        public int GroupId { get; set; }

        //[ManyToOne]      // Many to one relationship with Groups

        public string Transponder { get; set; }
        public string LifeNumber { get; set; }
        public string StableNumber { get; set; }
        public int MainVetId { get; set; }
        public int SecondaryVetId { get; set; }
        public int DentistId { get; set; }
        public int SmithId { get; set; }
        public string Remarks { get; set; }
        public string MorningFood { get; set; }
        public string NoonFood { get; set; }
        public string EveningFood { get; set; }
        public string MorningSupplement { get; set; }
        public string NoonSupplement { get; set; }
        public string EveningSupplement { get; set; }
        public DateTime? LastModified { get; set; }
        public string Group_name { get; set; }

        public Horse()
        {
            Id = 0;
            Name = String.Empty;
            Sex = String.Empty;
            Mother = String.Empty;
            Father = String.Empty;
            Birthyear = String.Empty;
            Deleted = false;
            IsChecked = false;
            GroupId = 0;
            Transponder = String.Empty;
            LifeNumber = String.Empty;
            StableNumber = String.Empty;
            MainVetId = 0;
            SecondaryVetId = 0;
            DentistId = 0;
            SmithId = 0;
            Remarks = String.Empty;
            MorningFood = String.Empty;
            NoonFood = String.Empty;
            EveningFood = String.Empty;
            MorningSupplement = String.Empty;
            NoonSupplement = String.Empty;
            EveningSupplement = String.Empty;
            Group_name = String.Empty;
        }

        public Horse(ParseObject parseObject)
            : this()
        {
            int id;
            parseObject.TryGetValue(nameof(Id), out id);
            Id = id;

            string name;
            parseObject.TryGetValue(nameof(Name), out name);
            Name = name;

            string sex;
            parseObject.TryGetValue(nameof(Sex), out sex);
            Sex = sex;

            string mother;
            parseObject.TryGetValue(nameof(Mother), out mother);
            Mother = mother;

            string father;
            parseObject.TryGetValue(nameof(Father), out father);
            Father = father;

            string birthyear;
            parseObject.TryGetValue(nameof(Birthyear), out birthyear);
            Birthyear = birthyear;

            bool deleted;
            parseObject.TryGetValue(nameof(Deleted), out deleted);
            Deleted = deleted;

            bool isChecked;
            parseObject.TryGetValue(nameof(IsChecked), out isChecked);
            IsChecked = isChecked;

            int groupId;
            parseObject.TryGetValue(nameof(GroupId), out groupId);
            GroupId = groupId;

            string transponder;
            parseObject.TryGetValue(nameof(Transponder), out transponder);
            Transponder = transponder;

            string lifeNumber;
            parseObject.TryGetValue(nameof(LifeNumber), out lifeNumber);
            LifeNumber = lifeNumber;

            string stableNumber;
            parseObject.TryGetValue(nameof(StableNumber), out stableNumber);
            StableNumber = stableNumber;

            int mainVetId;
            parseObject.TryGetValue(nameof(MainVetId), out mainVetId);
            MainVetId = mainVetId;

            int secondaryVetId;
            parseObject.TryGetValue(nameof(SecondaryVetId), out secondaryVetId);
            SecondaryVetId = secondaryVetId;

            int dentistId;
            parseObject.TryGetValue(nameof(DentistId), out dentistId);
            DentistId = dentistId;

            int smithId;
            parseObject.TryGetValue(nameof(SmithId), out smithId);
            SmithId = smithId;

            string remarks;
            parseObject.TryGetValue(nameof(Remarks), out remarks);
            Remarks = remarks;

            string morningFood;
            parseObject.TryGetValue(nameof(MorningFood), out morningFood);
            MorningFood = morningFood;

            string noonFood;
            parseObject.TryGetValue(nameof(NoonFood), out noonFood);
            NoonFood = noonFood;

            string eveningFood;
            parseObject.TryGetValue(nameof(EveningFood), out eveningFood);
            EveningFood = eveningFood;

            string morningSupplement;
            parseObject.TryGetValue(nameof(MorningSupplement), out morningSupplement);
            MorningSupplement = morningSupplement;

            string noonSupplement;
            parseObject.TryGetValue(nameof(NoonSupplement), out noonSupplement);
            NoonSupplement = noonSupplement;

            string eveningSupplement;
            parseObject.TryGetValue(nameof(EveningSupplement), out eveningSupplement);
            EveningSupplement = eveningSupplement;

            DateTime? lastModified;
            parseObject.TryGetValue(nameof(LastModified), out lastModified);
            LastModified = lastModified;

            string groupName;
            parseObject.TryGetValue(nameof(Group_name), out groupName);
            Group_name = groupName;
        }
    }
}
