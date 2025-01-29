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


namespace Brar.Karanvir.RRCAGApp
{
    /// <summary>
    /// This is the form class for a sales quote
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        private const decimal salesTaxRate = 0.12M;
        private SalesQuote salesQuote;

        /// <summary>
        /// Initializes an instance of a sales quote form
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();

            // Attaching event handlers to the various controls.
            this.Load += SalesQuoteForm_Load;

            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;

            this.txtSalePrice.TextChanged += SalePriceOrTradeInValue_TextChanged;
            this.txtTradeInValue.TextChanged += SalePriceOrTradeInValue_TextChanged;

            this.chkStereoSystem.CheckedChanged += Accessories_CheckedChanged;
            this.chkLeatherInterior.CheckedChanged += Accessories_CheckedChanged;
            this.chkComputerNav.CheckedChanged += Accessories_CheckedChanged;

            this.radStandard.CheckedChanged += ExteriorFinish_CheckedChanged;
            this.radPearlized.CheckedChanged += ExteriorFinish_CheckedChanged;
            this.radCustomized.CheckedChanged += ExteriorFinish_CheckedChanged;

            this.nudNoOfYears.ValueChanged += PaymentDetails_Changed;
            this.nudAnunualIntRate.ValueChanged += PaymentDetails_Changed;


            this.btnReset.Click += BtnReset_Click;
        }

        /// <summary>
        /// Handles the Load event for the sales quote form.
        /// </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            this.txtSalePrice.Focus();

            this.lblSalesTax.Text = string.Format("Sales Tax ({0:P0}):", salesTaxRate);

            this.salesQuote = null;

            this.errorProvider.SetError(this.txtSalePrice, string.Empty);
            this.errorProvider.SetError(this.txtTradeInValue, string.Empty);
        }


        /// <summary>
        /// Handles the click event for the calculate quote button.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            decimal salePrice = 0;
            decimal tradeInValue = 0;
            Accessories accessoriesChosen;
            ExteriorFinish exteriorFinishChosen;

            this.errorProvider.SetError(this.txtSalePrice, string.Empty);
            this.errorProvider.SetError(this.txtTradeInValue, string.Empty);
            this.errorProvider.SetIconPadding(this.txtSalePrice, 3);
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);

            if (this.txtSalePrice.Text == string.Empty)
            {
                this.errorProvider.SetError(txtSalePrice, "Vehicle price is a required field.");
            }

            if (this.errorProvider.GetError(this.txtSalePrice) == string.Empty)
            {
                try
                {
                    salePrice = decimal.Parse(this.txtSalePrice.Text);
                }
                catch (Exception)
                {
                    this.errorProvider.SetError(txtSalePrice, "Vehicle price cannot contain letters or special characters.");
                }
            }

            if (this.errorProvider.GetError(this.txtSalePrice) == string.Empty)
            {
                if (salePrice <= 0)
                {
                    this.errorProvider.SetError(txtSalePrice, "Vehicle price cannot be less than or equal to 0.");
                }
            }

            if (this.txtTradeInValue.Text == string.Empty)
            {
                this.errorProvider.SetError(txtTradeInValue, "Trade-in value is a required field.");
            }

            if (this.errorProvider.GetError(this.txtTradeInValue) == string.Empty)
            {
                try
                {
                    tradeInValue = decimal.Parse(this.txtTradeInValue.Text);
                }
                catch (Exception)
                {
                    this.errorProvider.SetError(txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
                }
            }

            if (this.errorProvider.GetError(this.txtTradeInValue) == string.Empty)
            {
                if (tradeInValue < 0)
                {
                    this.errorProvider.SetError(txtTradeInValue, "Trade-in value cannot be less than 0.");
                }
            }

            if (this.errorProvider.GetError(this.txtTradeInValue) == string.Empty &&
                this.errorProvider.GetError(this.txtSalePrice) == string.Empty)
            {
                if (tradeInValue > salePrice)
                {
                    this.errorProvider.SetError(txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                }
            }

            if (this.errorProvider.GetError(this.txtTradeInValue) == string.Empty &&
            this.errorProvider.GetError(this.txtSalePrice) == string.Empty)
            {
                accessoriesChosen = this.FindAccessoriesChosen();

                exteriorFinishChosen = this.FindExteriorFinishChosen();

                salesQuote = new SalesQuote(salePrice, tradeInValue, salesTaxRate, accessoriesChosen, exteriorFinishChosen);

                this.lblSalePriceValue.Text = string.Format("{0:C}", salesQuote.VehicleSalePrice);
                this.lblOptionsValue.Text = string.Format("{0:N}", salesQuote.TotalOptions);
                this.lblSubTotalValue.Text = string.Format("{0:C}", salesQuote.SubTotal);
                this.lblSalesTaxValue.Text = string.Format("{0:N}", salesQuote.SalesTax);
                this.lblTotalValue.Text = string.Format("{0:C}", salesQuote.Total);
                this.lblTradeInAmount.Text = string.Format("{0:N}", (0 - salesQuote.TradeInAmount));
                this.lblAmountDueValue.Text = string.Format("{0:C}", salesQuote.AmountDue);

                decimal monthlyPayment = Financial.GetPayment((nudAnunualIntRate.Value / 100) / 12, Decimal.ToInt32(nudNoOfYears.Value) * 12, salesQuote.AmountDue);
                this.lblMonthlyPaymentValue.Text = string.Format("{0:C}", monthlyPayment);
            }

        }

        /// <summary>
        /// Handles the vehicle sale price and trade in value text changed event.
        /// </summary>
        private void SalePriceOrTradeInValue_TextChanged(object sender, EventArgs e)
        {
            this.lblSalePriceValue.Text = "";
            this.lblOptionsValue.Text = "";
            this.lblSubTotalValue.Text = "";
            this.lblSalesTaxValue.Text = "";
            this.lblTotalValue.Text = "";
            this.lblTradeInAmount.Text = "";
            this.lblAmountDueValue.Text = "";

            this.lblMonthlyPaymentValue.Text = "";

            salesQuote = null;
        }

        /// <summary>
        /// Handles the accessories changed event.
        /// </summary>
        private void Accessories_CheckedChanged(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                Accessories accessoriesChosen = this.FindAccessoriesChosen();

                salesQuote.AccessoriesChosen = accessoriesChosen;

                this.lblOptionsValue.Text = string.Format("{0:N}", salesQuote.TotalOptions);
                this.lblSubTotalValue.Text = string.Format("{0:C}", salesQuote.SubTotal);
                this.lblSalesTaxValue.Text = string.Format("{0:N}", salesQuote.SalesTax);
                this.lblTotalValue.Text = string.Format("{0:C}", salesQuote.Total);
                this.lblAmountDueValue.Text = string.Format("{0:C}", salesQuote.AmountDue);

                decimal monthlyPayment = Financial.GetPayment((nudAnunualIntRate.Value / 100) / 12, Decimal.ToInt32(nudNoOfYears.Value) * 12, salesQuote.AmountDue);
                this.lblMonthlyPaymentValue.Text = string.Format("{0:C}", monthlyPayment);
            }
        }

        /// <summary>
        /// Handles the exterior finish changed event.
        /// </summary>
        private void ExteriorFinish_CheckedChanged(object sender, EventArgs e)
        {
            if(salesQuote != null)
            {
                ExteriorFinish exteriorFinishChosen = this.FindExteriorFinishChosen();

                salesQuote.ExteriorFinishChosen = exteriorFinishChosen;

                this.lblOptionsValue.Text = string.Format("{0:N}", salesQuote.TotalOptions);
                this.lblSubTotalValue.Text = string.Format("{0:C}", salesQuote.SubTotal);
                this.lblSalesTaxValue.Text = string.Format("{0:N}", salesQuote.SalesTax);
                this.lblTotalValue.Text = string.Format("{0:C}", salesQuote.Total);
                this.lblAmountDueValue.Text = string.Format("{0:C}", salesQuote.AmountDue);

                decimal monthlyPayment = Financial.GetPayment((nudAnunualIntRate.Value / 100) / 12, Decimal.ToInt32(nudNoOfYears.Value) * 12, salesQuote.AmountDue);
                this.lblMonthlyPaymentValue.Text = string.Format("{0:C}", monthlyPayment);
            }
        }

        /// <summary>
        /// Handles monthly payment and no. of years changed event.
        /// </summary>
        private void PaymentDetails_Changed(object sender, EventArgs e)
        {
            if (salesQuote != null)
            {
                decimal monthlyPayment = Financial.GetPayment((nudAnunualIntRate.Value / 100) / 12, Decimal.ToInt32(nudNoOfYears.Value) * 12, salesQuote.AmountDue);
                this.lblMonthlyPaymentValue.Text = string.Format("{0:C}", monthlyPayment);
            }
        }

        /// <summary>
        /// Handles the click event for the reset button.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            string message = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    this.errorProvider.SetError(this.txtSalePrice, string.Empty);
                    this.errorProvider.SetError(this.txtTradeInValue, string.Empty);

                    this.lblSalePriceValue.Text = "";
                    this.lblOptionsValue.Text = "";
                    this.lblSubTotalValue.Text = "";
                    this.lblSalesTaxValue.Text = "";
                    this.lblTotalValue.Text = "";
                    this.lblTradeInAmount.Text = "";
                    this.lblAmountDueValue.Text = "";

                    this.lblMonthlyPaymentValue.Text = "";

                    this.chkStereoSystem.Checked = false;
                    this.chkLeatherInterior.Checked = false;
                    this.chkComputerNav.Checked = false;

                    this.radStandard.Checked = true;
                    this.radPearlized.Checked = false;
                    this.radCustomized.Checked = false;

                    this.txtSalePrice.Focus();
                    this.txtSalePrice.Text = "";
                    this.txtTradeInValue.Text = "0";

                    this.nudNoOfYears.Value = 1;
                    this.nudAnunualIntRate.Value = 5;

                    salesQuote = null;
                    break;

                case DialogResult.No:
                    // user pressed No
                    break;
            }
        }

        /// <summary>
        /// Finds out the accessories chosen for the sales quote from the accessory options.
        /// </summary>
        /// <returns>The Accessories chosen</returns>
        private Accessories FindAccessoriesChosen()
        {
            Accessories accessoriesChosen = Accessories.None;

            if (this.chkComputerNav.Checked && this.chkLeatherInterior.Checked && this.chkStereoSystem.Checked)
            {
                accessoriesChosen = Accessories.All;
            }
            else if (this.chkStereoSystem.Checked && this.chkComputerNav.Checked)
            {
                accessoriesChosen = Accessories.StereoAndNavigation;
            }
            else if (this.chkStereoSystem.Checked && this.chkLeatherInterior.Checked)
            {
                accessoriesChosen = Accessories.StereoAndLeather;
            }
            else if (this.chkComputerNav.Checked && this.chkLeatherInterior.Checked)
            {
                accessoriesChosen = Accessories.LeatherAndNavigation;
            }
            else if (this.chkStereoSystem.Checked)
            {
                accessoriesChosen = Accessories.StereoSystem;
            }
            else if (this.chkLeatherInterior.Checked)
            {
                accessoriesChosen = Accessories.LeatherInterior;
            }
            else if (this.chkComputerNav.Checked)
            {
                accessoriesChosen = Accessories.ComputerNavigation;
            }

            return accessoriesChosen;
        }

        /// <summary>
        /// Finds out the exterior finish chosen for the sales quote from the exterior finish options.
        /// </summary>
        /// <returns>The exterior finish chosen</returns>
        private ExteriorFinish FindExteriorFinishChosen()
        {
            ExteriorFinish exteriorFinishChosen = ExteriorFinish.Standard;

            if (this.radPearlized.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Pearlized;
            }
            else if (this.radCustomized.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Custom;
            }

            return exteriorFinishChosen;
        }
    }
}
