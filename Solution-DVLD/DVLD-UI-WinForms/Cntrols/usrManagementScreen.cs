using DVLD.WinForms.UI;
using System;
using System.Windows.Forms;

namespace DVLD.WinForms.Cntrols
{
    public partial class usrManagementScreen : UserControl
    {
        public usrManagementScreen()
        {
            InitializeComponent();
            clsUIHelper.ApplyTheme(this);
        }

        public object DataSource
        {
            get { return dgvResults.DataSource; }
            set { dgvResults.DataSource = value; }
        }

        public string ScreenTitle
        {
            get { return usrHeaderManagementScreen.Title; }
            set { usrHeaderManagementScreen.Title = value; }
        }

        public int RecordsCount
        {
            set { lblRecordsCount.Text = $"Records: {value}"; }
        }

        public object SelectedFilterItem
        {
            get { return cbFilterBy.SelectedItem; }
            set { cbFilterBy.SelectedItem = value; }
        }

        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public ContextMenuStrip GridContextMenu
        {
            get { return dgvResults.ContextMenuStrip; }
            set { dgvResults.ContextMenuStrip = value; }
        }

        public string[] NumericFilterFields { get; set; }

        public void SetFilterOptions(string[] options)
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.AddRange(options);
            if (cbFilterBy.Items.Count > 0)
                cbFilterBy.SelectedIndex = 0;
        }

        public void PopulateFilterOptionsFromGrid()
        {
            cbFilterBy.Items.Clear();
            cbFilterBy.Items.Add("None"); 

            foreach (DataGridViewColumn column in dgvResults.Columns)
            {
                cbFilterBy.Items.Add(column.HeaderText);
            }

            if (cbFilterBy.Items.Count > 0)
            {
                cbFilterBy.SelectedIndex = 0;
            }
        }

        // Events

        public event EventHandler AddNewClick;

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewClick?.Invoke(this, e);
        }

        public event EventHandler SearchTextChanged;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, e);
        }

        public event EventHandler FilterByIndexChanged;

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isNone = cbFilterBy.Text == "None" || string.IsNullOrEmpty(cbFilterBy.Text);
            txtSearch.Visible = !isNone;
            if (isNone) txtSearch.Clear();
            else txtSearch.Focus();

            FilterByIndexChanged?.Invoke(this, e);
        }

        public event EventHandler CloseClick;

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(this, e);

            this.FindForm()?.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (NumericFilterFields != null
                && Array.Exists(NumericFilterFields, field => field.Equals(cbFilterBy.Text, StringComparison.OrdinalIgnoreCase)))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}


