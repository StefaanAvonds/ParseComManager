using ParseComManager.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParseComManager.Forms
{
    public partial class FVLogins : FormView<Login>
    {
        public FVLogins()
        {
            InitializeComponent();
        }

        protected override Task<List<Login>> DoRefreshDataSource()
        {
            return App.ParseManager.LoginTable.SelectAll();
        }
    }
}
