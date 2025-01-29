namespace Brar.Karanvir.RRCAGApp
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.grpAccessoryInput = new System.Windows.Forms.GroupBox();
            this.chkComputerNav = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinishInput = new System.Windows.Forms.GroupBox();
            this.radCustomized = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblAmountDueValue = new System.Windows.Forms.Label();
            this.lblTradeInAmount = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblSalesTaxValue = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.lblOptionsValue = new System.Windows.Forms.Label();
            this.lblSalePriceValue = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblSummarySalePrice = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPaymentValue = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.nudAnunualIntRate = new System.Windows.Forms.NumericUpDown();
            this.lblAnnnualIntRate = new System.Windows.Forms.Label();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.lblNoOfYears = new System.Windows.Forms.Label();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAccessoryInput.SuspendLayout();
            this.grpExteriorFinishInput.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnunualIntRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(12, 22);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblSalePrice.TabIndex = 0;
            this.lblSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(121, 19);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(120, 20);
            this.txtSalePrice.TabIndex = 1;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(36, 56);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(79, 13);
            this.lblTradeInValue.TabIndex = 2;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(121, 53);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(120, 20);
            this.txtTradeInValue.TabIndex = 2;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessoryInput
            // 
            this.grpAccessoryInput.Controls.Add(this.chkComputerNav);
            this.grpAccessoryInput.Controls.Add(this.chkLeatherInterior);
            this.grpAccessoryInput.Controls.Add(this.chkStereoSystem);
            this.grpAccessoryInput.Location = new System.Drawing.Point(16, 93);
            this.grpAccessoryInput.Name = "grpAccessoryInput";
            this.grpAccessoryInput.Size = new System.Drawing.Size(226, 158);
            this.grpAccessoryInput.TabIndex = 4;
            this.grpAccessoryInput.TabStop = false;
            this.grpAccessoryInput.Text = "Accessories";
            // 
            // chkComputerNav
            // 
            this.chkComputerNav.AutoSize = true;
            this.chkComputerNav.Location = new System.Drawing.Point(23, 105);
            this.chkComputerNav.Name = "chkComputerNav";
            this.chkComputerNav.Size = new System.Drawing.Size(125, 17);
            this.chkComputerNav.TabIndex = 5;
            this.chkComputerNav.Text = "Computer Navigation";
            this.chkComputerNav.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(23, 70);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 4;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(23, 34);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 3;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinishInput
            // 
            this.grpExteriorFinishInput.Controls.Add(this.radCustomized);
            this.grpExteriorFinishInput.Controls.Add(this.radPearlized);
            this.grpExteriorFinishInput.Controls.Add(this.radStandard);
            this.grpExteriorFinishInput.Location = new System.Drawing.Point(16, 259);
            this.grpExteriorFinishInput.Name = "grpExteriorFinishInput";
            this.grpExteriorFinishInput.Size = new System.Drawing.Size(226, 140);
            this.grpExteriorFinishInput.TabIndex = 5;
            this.grpExteriorFinishInput.TabStop = false;
            this.grpExteriorFinishInput.Text = "Exterior Finish";
            // 
            // radCustomized
            // 
            this.radCustomized.AutoSize = true;
            this.radCustomized.Location = new System.Drawing.Point(24, 93);
            this.radCustomized.Name = "radCustomized";
            this.radCustomized.Size = new System.Drawing.Size(123, 17);
            this.radCustomized.TabIndex = 6;
            this.radCustomized.Text = "Customized Detailing";
            this.radCustomized.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(24, 61);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 6;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(24, 29);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 6;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 28);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblAmountDueValue);
            this.grpSummary.Controls.Add(this.lblTradeInAmount);
            this.grpSummary.Controls.Add(this.lblTotalValue);
            this.grpSummary.Controls.Add(this.lblSalesTaxValue);
            this.grpSummary.Controls.Add(this.lblSubTotalValue);
            this.grpSummary.Controls.Add(this.lblOptionsValue);
            this.grpSummary.Controls.Add(this.lblSalePriceValue);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.lblSummarySalePrice);
            this.grpSummary.Location = new System.Drawing.Point(281, 19);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(305, 259);
            this.grpSummary.TabIndex = 7;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblAmountDueValue
            // 
            this.lblAmountDueValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDueValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDueValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmountDueValue.Location = new System.Drawing.Point(146, 217);
            this.lblAmountDueValue.Name = "lblAmountDueValue";
            this.lblAmountDueValue.Size = new System.Drawing.Size(122, 20);
            this.lblAmountDueValue.TabIndex = 19;
            this.lblAmountDueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeInAmount
            // 
            this.lblTradeInAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeInAmount.Location = new System.Drawing.Point(146, 185);
            this.lblTradeInAmount.Name = "lblTradeInAmount";
            this.lblTradeInAmount.Size = new System.Drawing.Size(122, 20);
            this.lblTradeInAmount.TabIndex = 18;
            this.lblTradeInAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalValue.Location = new System.Drawing.Point(146, 153);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(122, 20);
            this.lblTotalValue.TabIndex = 17;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxValue
            // 
            this.lblSalesTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxValue.Location = new System.Drawing.Point(146, 121);
            this.lblSalesTaxValue.Name = "lblSalesTaxValue";
            this.lblSalesTaxValue.Size = new System.Drawing.Size(122, 20);
            this.lblSalesTaxValue.TabIndex = 16;
            this.lblSalesTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotalValue.Location = new System.Drawing.Point(146, 89);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.Size = new System.Drawing.Size(122, 20);
            this.lblSubTotalValue.TabIndex = 15;
            this.lblSubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptionsValue
            // 
            this.lblOptionsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptionsValue.Location = new System.Drawing.Point(146, 57);
            this.lblOptionsValue.Name = "lblOptionsValue";
            this.lblOptionsValue.Size = new System.Drawing.Size(122, 20);
            this.lblOptionsValue.TabIndex = 14;
            this.lblOptionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalePriceValue
            // 
            this.lblSalePriceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalePriceValue.Location = new System.Drawing.Point(146, 25);
            this.lblSalePriceValue.Name = "lblSalePriceValue";
            this.lblSalePriceValue.Size = new System.Drawing.Size(122, 20);
            this.lblSalePriceValue.TabIndex = 13;
            this.lblSalePriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(71, 221);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "Amount Due:";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.AutoSize = true;
            this.lblTradeIn.Location = new System.Drawing.Point(91, 189);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(49, 13);
            this.lblTradeIn.TabIndex = 10;
            this.lblTradeIn.Text = "Trade-in:";
            this.lblTradeIn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(106, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(56, 125);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(84, 13);
            this.lblSalesTax.TabIndex = 6;
            this.lblSalesTax.Text = "Sales Tax (xx%):";
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(91, 93);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(94, 61);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(46, 13);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Options:";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSummarySalePrice
            // 
            this.lblSummarySalePrice.AutoSize = true;
            this.lblSummarySalePrice.Location = new System.Drawing.Point(37, 29);
            this.lblSummarySalePrice.Name = "lblSummarySalePrice";
            this.lblSummarySalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblSummarySalePrice.TabIndex = 0;
            this.lblSummarySalePrice.Text = "Vehicle\'s Sale Price:";
            this.lblSummarySalePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthlyPaymentValue);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.nudAnunualIntRate);
            this.grpFinance.Controls.Add(this.lblAnnnualIntRate);
            this.grpFinance.Controls.Add(this.nudNoOfYears);
            this.grpFinance.Controls.Add(this.lblNoOfYears);
            this.grpFinance.Location = new System.Drawing.Point(282, 288);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(304, 111);
            this.grpFinance.TabIndex = 8;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthlyPaymentValue
            // 
            this.lblMonthlyPaymentValue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPaymentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPaymentValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMonthlyPaymentValue.Location = new System.Drawing.Point(199, 64);
            this.lblMonthlyPaymentValue.Name = "lblMonthlyPaymentValue";
            this.lblMonthlyPaymentValue.Size = new System.Drawing.Size(85, 20);
            this.lblMonthlyPaymentValue.TabIndex = 9;
            this.lblMonthlyPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(196, 40);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblMonthlyPayment.TabIndex = 4;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // nudAnunualIntRate
            // 
            this.nudAnunualIntRate.BackColor = System.Drawing.SystemColors.Window;
            this.nudAnunualIntRate.DecimalPlaces = 2;
            this.nudAnunualIntRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnunualIntRate.Location = new System.Drawing.Point(113, 64);
            this.nudAnunualIntRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnunualIntRate.Name = "nudAnunualIntRate";
            this.nudAnunualIntRate.Size = new System.Drawing.Size(63, 20);
            this.nudAnunualIntRate.TabIndex = 8;
            this.nudAnunualIntRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblAnnnualIntRate
            // 
            this.lblAnnnualIntRate.AutoSize = true;
            this.lblAnnnualIntRate.Location = new System.Drawing.Point(110, 27);
            this.lblAnnnualIntRate.MaximumSize = new System.Drawing.Size(70, 0);
            this.lblAnnnualIntRate.Name = "lblAnnnualIntRate";
            this.lblAnnnualIntRate.Size = new System.Drawing.Size(68, 26);
            this.lblAnnnualIntRate.TabIndex = 2;
            this.lblAnnnualIntRate.Text = "Annual Interest Rate";
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(21, 64);
            this.nudNoOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(63, 20);
            this.nudNoOfYears.TabIndex = 7;
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNoOfYears
            // 
            this.lblNoOfYears.AutoSize = true;
            this.lblNoOfYears.Location = new System.Drawing.Point(18, 40);
            this.lblNoOfYears.Name = "lblNoOfYears";
            this.lblNoOfYears.Size = new System.Drawing.Size(66, 13);
            this.lblNoOfYears.TabIndex = 0;
            this.lblNoOfYears.Text = "No. of Years";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(478, 406);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(108, 28);
            this.btnCalculateQuote.TabIndex = 9;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 446);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpExteriorFinishInput);
            this.Controls.Add(this.grpAccessoryInput);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.lblSalePrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessoryInput.ResumeLayout(false);
            this.grpAccessoryInput.PerformLayout();
            this.grpExteriorFinishInput.ResumeLayout(false);
            this.grpExteriorFinishInput.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnunualIntRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessoryInput;
        private System.Windows.Forms.CheckBox chkComputerNav;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinishInput;
        private System.Windows.Forms.RadioButton radCustomized;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblSummarySalePrice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Label lblNoOfYears;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;
        private System.Windows.Forms.Label lblAnnnualIntRate;
        private System.Windows.Forms.NumericUpDown nudAnunualIntRate;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblAmountDueValue;
        private System.Windows.Forms.Label lblTradeInAmount;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblSalesTaxValue;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Label lblOptionsValue;
        private System.Windows.Forms.Label lblSalePriceValue;
        private System.Windows.Forms.Label lblMonthlyPaymentValue;
    }
}