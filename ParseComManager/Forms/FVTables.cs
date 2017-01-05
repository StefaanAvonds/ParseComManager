using ParseComManager.Parse;
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
    public partial class FVTables : Form
    {
        private IEnumerable<ParseTableNames> _tables;

        public FVTables()
        {
            InitializeComponent();

            _tables = Enum.GetValues(typeof(ParseTableNames)).Cast<ParseTableNames>();
        }

        private void FVTables_Load(object sender, EventArgs e)
        {
            ReloadDataSource();
        }

        /// <summary>
        /// Reload the DataSource with all possible tables.
        /// </summary>
        private void ReloadDataSource()
        {
            var table = new DataTable();
            var column = new DataColumn("Table", typeof(String));
            table.Columns.Add(column);
            
            foreach (var tableName in _tables)
            {
                var row = table.NewRow();
                row["Table"] = tableName.ToString();

                table.Rows.Add(row);
            }

            gridTables.DataSource = table;
        }

        private void gridTables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = gridTables[e.ColumnIndex, e.RowIndex].Value.ToString();

            ParseTableNames selectedTable;
            Enum.TryParse<ParseTableNames>(value, out selectedTable);
            
            switch (selectedTable)
            {
                case ParseTableNames.Calendar:
                    var pageCalendar = new FVCalendar();
                    pageCalendar.MdiParent = this;
                    pageCalendar.Show();
                    break;
                case ParseTableNames.Contact:
                    var pageContact = new FVContact();
                    pageContact.MdiParent = this;
                    pageContact.Show();
                    break;
                case ParseTableNames.Groups:
                    var pageGroups = new FVGroups();
                    pageGroups.MdiParent = this;
                    pageGroups.Show();
                    break;
                case ParseTableNames.Holiday:
                    var pageHoliday = new FVHoliday();
                    pageHoliday.MdiParent = this;
                    pageHoliday.Show();
                    break;
                case ParseTableNames.Horse:
                    var pageHorse = new FVHorse();
                    pageHorse.MdiParent = this;
                    pageHorse.Show();
                    break;
                case ParseTableNames.HorseContact:
                    var pageHorseContact = new FVHorseContact();
                    pageHorseContact.MdiParent = this;
                    pageHorseContact.Show();
                    break;
                case ParseTableNames.Login:
                    var pageLogin = new FVLogins();
                    pageLogin.MdiParent = this;
                    pageLogin.Show();
                    break;
                case ParseTableNames.Schedule:
                    var pageSchedule = new FVSchedule();
                    pageSchedule.MdiParent = this;
                    pageSchedule.Show();
                    break;
                case ParseTableNames.Settings:
                    var pageSettings = new FVSettings();
                    pageSettings.MdiParent = this;
                    pageSettings.Show();
                    break;
                case ParseTableNames.Tasks:
                    var pageTasks = new FVTasks();
                    pageTasks.MdiParent = this;
                    pageTasks.Show();
                    break;
            }
        }
    }
}
