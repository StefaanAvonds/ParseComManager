using ParseComManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseComManager.Forms
{
    public partial class FormView<TDataModel> : Form
        where TDataModel : IDataModel
    {
        public FormView()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("parse.ico");
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        protected async void ReloadData()
        {
            grid.DataSource = await DoRefreshDataSource();
        }

        protected virtual Task<List<TDataModel>> DoRefreshDataSource()
        {
            return Task.Factory.StartNew(() => new List<TDataModel>());
        }
    }
}
