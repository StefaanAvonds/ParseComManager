using ParseComManager.Interfaces;

namespace ParseComManager.Parse.Tables
{
    public class BaseParseTable<TDataModel>
        where TDataModel : IDataModel, new()
    {
        private ParseTableNames _tableName;

        protected ParseTableNames TableName
        {
            get { return _tableName; }
        }

        public BaseParseTable(ParseTableNames tableName)
        {
            _tableName = tableName;
        }
    }
}
