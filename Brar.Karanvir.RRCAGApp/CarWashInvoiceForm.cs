using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV.Forms;

namespace Brar.Karanvir.RRCAGApp
{
    /// <summary>
    /// This is the form class for the car wash invoice form
    /// </summary>
    public partial class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {
        private BindingSource carWashInvoiceSource;

        /// <summary>
        /// Initializes an instance of the car wash invoice form
        /// </summary>
        /// <param name="bindingSource">The binding source object which will be used for data binding controls in the form</param>
        public CarWashInvoiceForm(BindingSource bindingSource)
        {
            InitializeComponent();

            this.carWashInvoiceSource = bindingSource;

            BindControls();

            this.Load += CarWashInvoiceForm_Load;
        }

        /// <summary>
        /// Handles the load event for the car wash invoice form
        /// </summary>
        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {
            this.Text = "Car Wash Invoice";
        }

        /// <summary>
        /// Binds the various form controls to object data
        /// </summary>
        private void BindControls()
        {
            Binding packageBind = new Binding("Text", this.carWashInvoiceSource, "PackageCost");

            packageBind.FormattingEnabled = true;
            packageBind.FormatString = "C";

            this.lblPackagePrice.DataBindings.Add(packageBind);

            Binding fragaranceBind = new Binding("Text", this.carWashInvoiceSource, "FragranceCost");

            fragaranceBind.FormattingEnabled = true;
            fragaranceBind.FormatString = "C";

            this.lblFragrancePrice.DataBindings.Add(fragaranceBind);

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
