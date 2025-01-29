using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Brar.Karanvir.RRCAGApp
{
    /// <summary>
    /// This is the form class for the vehicle data form
    /// </summary>
    public partial class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;


        /// <summary>
        /// Initializes an instance of the vehicle data form
        /// </summary>
        public VehicleDataForm()
        {
            InitializeComponent();

            RetrieveDataFromDatabase();

            BindControls();

            this.Load += VehicleDataForm_Load;
        }

        /// <summary>
        /// Handles the click event of the delete menu item
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            string stockNumber = this.dgvVehicles.CurrentRow.Cells["StockNumber"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete stock item {stockNumber}", "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            switch(result)
            {
                case DialogResult.Yes:
                    try
                    {
                        int rowIndex = this.dgvVehicles.CurrentRow.Index;

                        this.dataset.Tables[0].Rows[rowIndex].Delete();

                        this.bindingSource.EndEdit();
                        this.adapter.Update(this.dataset, "VehicleStock");

                        this.Text = "Vehicle Data";
                        this.mnuEditDelete.Enabled = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while deleting the selected vehicle.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case DialogResult.No:
                    break;
            }
            
            
        }

        /// <summary>
        /// Handles the selection changed event of the data grid view
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dgvVehicles.CurrentRow.Selected && !this.dgvVehicles.CurrentRow.IsNewRow)
            {
                this.mnuEditDelete.Enabled = true;
            }
            else
            {
                this.mnuEditDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the closing event of the vehicle data form
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.bindingSource.EndEdit();

            if(this.dataset.HasChanges())
            {
                DialogResult result = MessageBox.Show("Do you wish to save the changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch(result)
                {
                    case DialogResult.Yes:
                        try
                        {
                            this.dgvVehicles.EndEdit();
                            this.adapter.Update(this.dataset, "VehicleStock");

                            this.connection.Close();
                            this.connection.Dispose();
                        }
                        catch(Exception)
                        {
                            DialogResult failedResult = MessageBox.Show("An error occurred while saving the changes. Do you still wish to close this window?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                            
                            switch(failedResult)
                            {
                                case DialogResult.Yes:
                                    break;
                                case DialogResult.No:
                                    e.Cancel = true;
                                    break;
                            }
                        }
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                this.dgvVehicles.EndEdit();
                this.adapter.Update(this.dataset, "VehicleStock");

                this.connection.Close();
                this.connection.Dispose();
            }
        }

        /// <summary>
        /// Handles the click event of the save menu item.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            this.dgvVehicles.EndEdit();
            this.bindingSource.EndEdit();

            try
            {
                this.adapter.Update(this.dataset, "VehicleStock");
                this.Text = "Vehicle Data";
                this.mnuFileSave.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the cell value changed event of the data grid view.
        /// </summary>
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "* Vehicle Data";
            this.mnuFileSave.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the Close menu item.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the load event for the form.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            this.dgvVehicles.Columns["ID"].Visible = false;
            this.dgvVehicles.Columns["SoldBy"].Visible = false;

            this.mnuFileSave.Enabled = false;
            this.mnuEditDelete.Enabled = false;
            this.Text = "Vehicle Data";
            this.WindowState = FormWindowState.Maximized;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.mnuFileClose.Click += MnuFileClose_Click;
            this.FormClosing += VehicleDataForm_FormClosing;
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged;
            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            this.mnuFileSave.Click += MnuFileSave_Click;
            this.mnuEditDelete.Click += MnuEditDelete_Click;
            this.dgvVehicles.RowsAdded += DgvVehicles_RowsAdded;
            this.adapter.RowUpdated += new OleDbRowUpdatedEventHandler(dataAdapter_RowUpdated);
        }

        /// <summary>
        /// Handles the New Rows added event for the data grid view.
        /// </summary>
        private void DgvVehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvVehicles.Rows[e.RowIndex - 1].Cells["SoldBy"].Value = 0;
        }

        /// <summary>
        /// Handles the row updated event of the data adapter.
        /// </summary>
        private void dataAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if(e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", connection);

                e.Row["ID"] = (int)cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Retrieves data from the database.
        /// </summary>
        private void RetrieveDataFromDatabase()
        {
            this.connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"AMDatabase.mdb\"");
            this.connection.Open();

            OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM VehicleStock");
            selectCommand.Connection = this.connection;


            this.adapter = new OleDbDataAdapter();
            this.adapter.SelectCommand = selectCommand;

            this.dataset = new DataSet();

            this.adapter.Fill(this.dataset, "VehicleStock");

            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder();

            commandBuilder.DataAdapter = this.adapter;
            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

            this.adapter.InsertCommand = commandBuilder.GetInsertCommand();
            this.adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            this.adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
        }

        /// <summary>
        /// BData binds grid view control.
        /// </summary>
        private void BindControls()
        {
            this.bindingSource = new BindingSource();

            this.bindingSource.DataSource = this.dataset.Tables[0];

            this.dgvVehicles.DataSource = this.bindingSource;
        }
    }
}
