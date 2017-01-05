using ParseComManager.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseComManager.Forms
{
    public partial class FVGroups : FormView<Groups>
    {
        public FVGroups()
        {
            InitializeComponent();
        }

        protected override Task<List<Groups>> DoRefreshDataSource()
        {
            return App.ParseManager.GroupsTable.SelectAll();
        }
    }
}
