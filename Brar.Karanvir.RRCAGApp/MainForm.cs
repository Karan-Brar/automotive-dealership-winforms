using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV.Forms;

namespace Brar.Karanvir.RRCAGApp
{
    /// <summary>
    /// This is the form class for the main form.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes an instance of the main form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Attaching events to the various controls
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuSalesQuote.Click += MnuSalesQuote_Click;
            this.mnuCarWash.Click += MnuCarWash_Click;
            this.mnuDataVehicles.Click += MnuDataVehicles_Click;

        }

        /// <summary>
        /// Handles the click event for the Vehicles menu item under data item.
        /// </summary>
        private void MnuDataVehicles_Click(object sender, EventArgs e)
        {
            bool formExists = false;


            foreach(Form child in this.MdiChildren)
            {
                if(child.GetType().Equals(typeof(VehicleDataForm)))
                {
                    formExists = true;
                    child.Focus();
                }
            }

            if (!formExists)
            {
                try
                {
                    VehicleDataForm vehicleDataForm = new VehicleDataForm();

                    vehicleDataForm.MdiParent = this;

                    vehicleDataForm.Show();
                }
                catch(Exception)
                {
                    MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the click event for the car wash item under the File --> Open item.
        /// </summary>
        private void MnuCarWash_Click(object sender, EventArgs e)
        {
            try
            {
                CarWashForm carWashForm = new CarWashForm();

                carWashForm.MdiParent = this;

                carWashForm.Show();
            }
            catch(FileNotFoundException)
            {
                string message = "Fragrances data file not found.";
                string caption = "Data File Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;

                MessageBox.Show(message, caption, buttons, icon);
            }
            catch (Exception)
            {
                string message = "An error occurred while reading the data file.";
                string caption = "Data File Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;

                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        /// <summary>
        /// Handles the Click Event of the sales quote menu item under the File --> Open item.
        /// </summary>
        private void MnuSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm salesQuoteForm = new SalesQuoteForm();

            salesQuoteForm.MdiParent = this;

            salesQuoteForm.Show();
        }

        /// <summary>
        /// Handles the Click Event of the About menu item under the Help menu item.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm;

            aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click Event of the exit menu item under the File menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
