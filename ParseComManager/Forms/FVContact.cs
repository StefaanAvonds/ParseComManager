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
    public partial class FVContact : FormView<Contact>
    {
        public FVContact()
        {
            InitializeComponent();
        }

        protected override Task<List<Contact>> DoRefreshDataSource()
        {
            return App.ParseManager.ContactTable.SelectAll();
        }
    }
}
