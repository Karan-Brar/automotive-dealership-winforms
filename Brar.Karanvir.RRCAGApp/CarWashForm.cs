using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brar.Karanvir.Business;
using ACE.BIT.ADEV.CarWash;
using System.IO;

namespace Brar.Karanvir.RRCAGApp
{
    /// <summary>
    /// This is the form class for the car wash form
    /// </summary>
    public partial class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private BindingSource fragrancesSource;
        private BindingList<CarWashItem> fragrances;

        private BindingSource packagesSource;
        private BindingList<Package> packages;

        private BindingSource carWashInvoiceSource;
        private CarWashInvoice carWashInvoice;

        private BindingSource ExteriorServicesSource;
        private BindingList<string> ExteriorServices;

        private BindingSource InteriorServicesSource;
        private BindingList<string> InteriorServices;

        /// <summary>
        /// Initializes an instance of the car wash form
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();

            // Initializing the binding sources, binding lists and setting up data sources for the binding sources.
            this.carWashInvoiceSource = new BindingSource();
            this.carWashInvoiceSource.DataSource = typeof(CarWashInvoice);

            this.ExteriorServicesSource = new BindingSource();
            this.ExteriorServices = new BindingList<string>();
            this.ExteriorServicesSource.DataSource = this.ExteriorServices;

            this.InteriorServicesSource = new BindingSource();
            this.InteriorServices = new BindingList<string>();
            this.InteriorServicesSource.DataSource = this.InteriorServices;

            this.fragrancesSource = new BindingSource();
            this.fragrances = new BindingList<CarWashItem>();

            this.packagesSource = new BindingSource();
            this.packages = new BindingList<Package>();

            // Creating a sorted list to store fragrance data read from the fragrances text file
            SortedList<string, decimal> fragranceList = new SortedList<string, decimal>();
            fragranceList.Add("Pine", 0M);

            FileStream stream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() != -1)
            {
                string fragranceInfo = reader.ReadLine();

                string[] data = fragranceInfo.Split(',');

                fragranceList.Add(data[0],decimal.Parse(data[1]));
            }

            reader.Close();
            stream.Dispose();

            // Adding key-value pairs from the sorted list to the fragrances binding list
            foreach (string key in fragranceList.Keys)
            {
                CarWashItem fragrance = new CarWashItem();
                fragrance.Description = key;
                fragrance.Price = fragranceList[key];

                fragrances.Add(fragrance);
            }

            this.fragrancesSource.DataSource = fragrances;

            // Creating various package objects with hard-coded values, these objects will be added to the packages binding list
            List<string> standardInteriorServices = new List<string> {};
            List<string> standardExteriorServices = new List<string> { "Hand Wash" };
            Package standard = new Package("Standard", 7.5M, standardInteriorServices, standardExteriorServices);
            packages.Add(standard);

            List<string> deluxeInteriorServices = new List<string> { "Shampoo Carpets" };
            List<string> deluxeExteriorServices = new List<string> { "Hand Wash", "Hand Wax" };
            Package deluxe = new Package("Deluxe", 15M, deluxeInteriorServices, deluxeExteriorServices);
            packages.Add(deluxe);

            List<string> executiveInteriorServices = new List<string> { "Shampoo Carpets" , "Shampoo Upholstery" };
            List<string> executiveExteriorServices = new List<string> { "Hand Wash", "Hand Wax", "Wheel Polish" };
            Package executive = new Package("Executive", 35M, executiveInteriorServices, executiveExteriorServices);
            packages.Add(executive);


            List<string> luxuryInteriorServices = new List<string> { "Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat" };
            List<string> luxuryExteriorServices = new List<string> { "Hand Wash", "Hand Wax", "Wheel Polish", "Detail Engine Compartment" };
            Package luxury = new Package("Luxury", 55M, luxuryInteriorServices, luxuryExteriorServices);
            packages.Add(luxury);


            this.packagesSource.DataSource = packages;
            
            // Binding controls to data
            BindControls();

            // Subscribing to various events
            this.Load += CarWashForm_Load;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;
        }

        /// <summary>
        /// Handles the click event for the generate invoice menu item
        /// </summary>
        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoiceForm = new CarWashInvoiceForm(carWashInvoiceSource);

            carWashInvoiceForm.FormClosing += CarWashInvoiceForm_FormClosing;

            carWashInvoiceForm.ShowDialog();
        }

        /// <summary>
        /// Handles the closing event for the car wash invoice modal form
        /// </summary>
        private void CarWashInvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mnuToolsGenerateInvoice.Enabled = false;

            this.cboFragrance.SelectedIndex = 4;

            this.cboPackage.SelectedIndex = -1;

            this.carWashInvoice = null;

            this.ExteriorServices.Clear();

            this.InteriorServices.Clear();

            this.lblSubtotal.Text = "";
            this.lblProvincialSalesTax.Text = "";
            this.lblGoodsAndServicesTax.Text = "";
            this.lblTotal.Text = "";
        }

        /// <summary>
        /// Handles the click event for the close menu item
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the selected index changed event for the fragrance combo box
        /// </summary>
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.carWashInvoice != null)
            {
                this.InteriorServices.Clear();

                Package selectedPackage = (Package)this.cboPackage.SelectedItem;
                CarWashItem selectedFragrance = (CarWashItem)this.cboFragrance.SelectedItem;

                this.carWashInvoice.FragranceCost = selectedFragrance.Price;
                
                carWashInvoiceSource.ResetBindings(true);
                carWashInvoiceSource.DataSource = carWashInvoice;

                string currentFragrance = selectedFragrance.Description;
                this.InteriorServices.Add(string.Format("Fragrance - {0}", currentFragrance));

                foreach (string item in selectedPackage.InteriorServices)
                {
                    this.InteriorServices.Add(item);
                }
            }
        }

        /// <summary>
        /// Handles the selected index changed for the package combo box
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboPackage.SelectedIndex != -1)
            {

                this.ExteriorServices.Clear();
                this.InteriorServices.Clear();

                this.mnuToolsGenerateInvoice.Enabled = true;


                Package selectedPackage = (Package)this.cboPackage.SelectedItem;
                CarWashItem selectedFragrance = (CarWashItem)this.cboFragrance.SelectedItem;

                foreach (string item in selectedPackage.ExteriorSerivces)
                {
                    this.ExteriorServices.Add(item);
                }

                string currentFragrance = selectedFragrance.Description;
                this.InteriorServices.Add(string.Format("Fragrance - {0}", currentFragrance));
                foreach (string item in selectedPackage.InteriorServices)
                {
                    this.InteriorServices.Add(item);
                }


                carWashInvoice = new CarWashInvoice(0, 0.05M, selectedPackage.Price, selectedFragrance.Price);
                this.carWashInvoiceSource.DataSource = carWashInvoice;
            }
        }

        /// <summary>
        /// Handles the load event for the car wash form
        /// </summary>
        private void CarWashForm_Load(object sender, EventArgs e)
        {
            this.Text = "Car Wash";

            this.mnuToolsGenerateInvoice.Enabled = false;

            int indexOfPine = 1;

            foreach(CarWashItem item in fragrancesSource)
            {
                if(item.Description == "Pine")
                {
                    indexOfPine = fragrancesSource.IndexOf(item);
                }
            }

            this.cboFragrance.SelectedIndex = indexOfPine;

            this.cboPackage.SelectedIndex = -1;
        }

        /// <summary>
        /// Binds the various form controls to object data
        /// </summary>
        private void BindControls()
        {
            this.cboFragrance.DataSource = this.fragrancesSource;
            this.cboFragrance.DisplayMember = "Description";

            
            this.cboPackage.DataSource = this.packagesSource;
            this.cboPackage.DisplayMember = "Description";


            this.lstInterior.DataSource = this.InteriorServicesSource;
            this.lstExterior.DataSource = this.ExteriorServicesSource;


            Binding subTotalBind = new Binding("Text", this.carWashInvoiceSource, "SubTotal");

            subTotalBind.FormattingEnabled = true;
            subTotalBind.FormatString = "C";

            this.lblSubtotal.DataBindings.Add(subTotalBind);

            Binding pstBind = new Binding("Text", this.carWashInvoiceSource, "ProvincialSalesTaxCharged");

            pstBind.FormattingEnabled = true;
            pstBind.FormatString = "0.00";

            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            Binding gstBind = new Binding("Text", this.carWashInvoiceSource, "GoodsAndServicesTaxCharged");

            gstBind.FormattingEnabled = true;
            gstBind.FormatString = "0.00";

            this.lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            Binding totalBind = new Binding("Text", this.carWashInvoiceSource, "Total");

            totalBind.FormattingEnabled = true;
            totalBind.FormatString = "C";

            this.lblTotal.DataBindings.Add(totalBind);           
        }
    }
}
