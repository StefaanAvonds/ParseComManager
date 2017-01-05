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
    public partial class FVCalendar : FormView<Calendar>
    {
        public FVCalendar()
        {
            InitializeComponent();
        }

        protected override Task<List<Calendar>> DoRefreshDataSource()
        {
            return App.ParseManager.CalendarTable.SelectAll();
        }
    }
}
