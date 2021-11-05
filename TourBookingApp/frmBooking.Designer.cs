
namespace TourBookingApp
{
    partial class frmBooking
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
            this.pnlTrip = new System.Windows.Forms.Panel();
            this.lbCapaInfo = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbStartInfo = new System.Windows.Forms.Label();
            this.lbEndInfo = new System.Windows.Forms.Label();
            this.lbAccInfo = new System.Windows.Forms.Label();
            this.lbDesInfo = new System.Windows.Forms.Label();
            this.lbPriceInfo = new System.Windows.Forms.Label();
            this.lbTourInfo = new System.Windows.Forms.Label();
            this.lbTotalInfo = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbAccommodation = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbTour = new System.Windows.Forms.Label();
            this.lbBooking = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.pnlTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTrip
            // 
            this.pnlTrip.Controls.Add(this.lbCapaInfo);
            this.pnlTrip.Controls.Add(this.lbCapacity);
            this.pnlTrip.Controls.Add(this.lbStartInfo);
            this.pnlTrip.Controls.Add(this.lbEndInfo);
            this.pnlTrip.Controls.Add(this.lbAccInfo);
            this.pnlTrip.Controls.Add(this.lbDesInfo);
            this.pnlTrip.Controls.Add(this.lbPriceInfo);
            this.pnlTrip.Controls.Add(this.lbTourInfo);
            this.pnlTrip.Controls.Add(this.lbTotalInfo);
            this.pnlTrip.Controls.Add(this.numQuantity);
            this.pnlTrip.Controls.Add(this.lbQuantity);
            this.pnlTrip.Controls.Add(this.lbTotal);
            this.pnlTrip.Controls.Add(this.lbPrice);
            this.pnlTrip.Controls.Add(this.lbDescription);
            this.pnlTrip.Controls.Add(this.lbAccommodation);
            this.pnlTrip.Controls.Add(this.lbStartDate);
            this.pnlTrip.Controls.Add(this.lbEndDate);
            this.pnlTrip.Controls.Add(this.lbTour);
            this.pnlTrip.Controls.Add(this.lbBooking);
            this.pnlTrip.Location = new System.Drawing.Point(5, 11);
            this.pnlTrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTrip.Name = "pnlTrip";
            this.pnlTrip.Size = new System.Drawing.Size(454, 379);
            this.pnlTrip.TabIndex = 0;
            // 
            // lbCapaInfo
            // 
            this.lbCapaInfo.AutoSize = true;
            this.lbCapaInfo.Location = new System.Drawing.Point(128, 305);
            this.lbCapaInfo.Name = "lbCapaInfo";
            this.lbCapaInfo.Size = new System.Drawing.Size(64, 20);
            this.lbCapaInfo.TabIndex = 23;
            this.lbCapaInfo.Text = "capacity";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(9, 305);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(95, 20);
            this.lbCapacity.TabIndex = 22;
            this.lbCapacity.Text = "Capacity left:";
            // 
            // lbStartInfo
            // 
            this.lbStartInfo.AutoSize = true;
            this.lbStartInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStartInfo.Location = new System.Drawing.Point(128, 77);
            this.lbStartInfo.Name = "lbStartInfo";
            this.lbStartInfo.Size = new System.Drawing.Size(68, 20);
            this.lbStartInfo.TabIndex = 21;
            this.lbStartInfo.Text = "startdate";
            // 
            // lbEndInfo
            // 
            this.lbEndInfo.AutoSize = true;
            this.lbEndInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEndInfo.Location = new System.Drawing.Point(128, 112);
            this.lbEndInfo.Name = "lbEndInfo";
            this.lbEndInfo.Size = new System.Drawing.Size(64, 20);
            this.lbEndInfo.TabIndex = 20;
            this.lbEndInfo.Text = "enddate";
            // 
            // lbAccInfo
            // 
            this.lbAccInfo.AutoSize = true;
            this.lbAccInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAccInfo.Location = new System.Drawing.Point(128, 144);
            this.lbAccInfo.Name = "lbAccInfo";
            this.lbAccInfo.Size = new System.Drawing.Size(118, 20);
            this.lbAccInfo.TabIndex = 19;
            this.lbAccInfo.Text = "accommodation";
            // 
            // lbDesInfo
            // 
            this.lbDesInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDesInfo.Location = new System.Drawing.Point(128, 181);
            this.lbDesInfo.Name = "lbDesInfo";
            this.lbDesInfo.Size = new System.Drawing.Size(311, 81);
            this.lbDesInfo.TabIndex = 18;
            this.lbDesInfo.Text = "description";
            // 
            // lbPriceInfo
            // 
            this.lbPriceInfo.AutoSize = true;
            this.lbPriceInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceInfo.Location = new System.Drawing.Point(128, 263);
            this.lbPriceInfo.Name = "lbPriceInfo";
            this.lbPriceInfo.Size = new System.Drawing.Size(42, 20);
            this.lbPriceInfo.TabIndex = 17;
            this.lbPriceInfo.Text = "price";
            // 
            // lbTourInfo
            // 
            this.lbTourInfo.AutoSize = true;
            this.lbTourInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourInfo.Location = new System.Drawing.Point(128, 45);
            this.lbTourInfo.Name = "lbTourInfo";
            this.lbTourInfo.Size = new System.Drawing.Size(62, 20);
            this.lbTourInfo.TabIndex = 16;
            this.lbTourInfo.Text = "tourinfo";
            // 
            // lbTotalInfo
            // 
            this.lbTotalInfo.AutoSize = true;
            this.lbTotalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalInfo.Location = new System.Drawing.Point(329, 352);
            this.lbTotalInfo.Name = "lbTotalInfo";
            this.lbTotalInfo.Size = new System.Drawing.Size(111, 25);
            this.lbTotalInfo.TabIndex = 10;
            this.lbTotalInfo.Text = "totalmoney";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(128, 331);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(99, 27);
            this.numQuantity.TabIndex = 8;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(9, 340);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(68, 20);
            this.lbQuantity.TabIndex = 7;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(270, 352);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(58, 25);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(9, 263);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 20);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(9, 181);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(88, 20);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Description:";
            // 
            // lbAccommodation
            // 
            this.lbAccommodation.AutoSize = true;
            this.lbAccommodation.Location = new System.Drawing.Point(9, 144);
            this.lbAccommodation.Name = "lbAccommodation";
            this.lbAccommodation.Size = new System.Drawing.Size(123, 20);
            this.lbAccommodation.TabIndex = 4;
            this.lbAccommodation.Text = "Accommodation:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(9, 77);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(79, 20);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = "Start Date:";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(9, 112);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(73, 20);
            this.lbEndDate.TabIndex = 2;
            this.lbEndDate.Text = "End Date:";
            // 
            // lbTour
            // 
            this.lbTour.AutoSize = true;
            this.lbTour.Location = new System.Drawing.Point(9, 45);
            this.lbTour.Name = "lbTour";
            this.lbTour.Size = new System.Drawing.Size(41, 20);
            this.lbTour.TabIndex = 1;
            this.lbTour.Text = "Tour:";
            // 
            // lbBooking
            // 
            this.lbBooking.AutoSize = true;
            this.lbBooking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBooking.Location = new System.Drawing.Point(109, 1);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(203, 32);
            this.lbBooking.TabIndex = 0;
            this.lbBooking.Text = "Trip Information";
            this.lbBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.btSearch);
            this.pnlCustomer.Controls.Add(this.cbSex);
            this.pnlCustomer.Controls.Add(this.dtpDOB);
            this.pnlCustomer.Controls.Add(this.txtEmail);
            this.pnlCustomer.Controls.Add(this.txtName);
            this.pnlCustomer.Controls.Add(this.txtPhone);
            this.pnlCustomer.Controls.Add(this.lbDOB);
            this.pnlCustomer.Controls.Add(this.lbSex);
            this.pnlCustomer.Controls.Add(this.lbEmail);
            this.pnlCustomer.Controls.Add(this.lbName);
            this.pnlCustomer.Controls.Add(this.lbPhone);
            this.pnlCustomer.Controls.Add(this.lbCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(470, 11);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(439, 379);
            this.pnlCustomer.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(199, 77);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(86, 31);
            this.btSearch.TabIndex = 20;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(86, 263);
            this.cbSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(138, 28);
            this.cbSex.TabIndex = 19;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(86, 212);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDOB.MaxDate = new System.DateTime(3309, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(324, 27);
            this.dtpDOB.TabIndex = 18;
            this.dtpDOB.Value = new System.DateTime(2021, 10, 9, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 160);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 112);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 27);
            this.txtName.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(86, 41);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(324, 27);
            this.txtPhone.TabIndex = 15;
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(17, 220);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(40, 20);
            this.lbDOB.TabIndex = 14;
            this.lbDOB.Text = "DOB";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(17, 267);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(35, 20);
            this.lbSex.TabIndex = 12;
            this.lbSex.Text = "Sex:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(17, 164);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(49, 20);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(17, 116);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 20);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Name:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(17, 45);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 20);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "Phone:";
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomer.Location = new System.Drawing.Point(99, 1);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(269, 32);
            this.lbCustomer.TabIndex = 1;
            this.lbCustomer.Text = "Customer Information";
            this.lbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConfirm.Location = new System.Drawing.Point(334, 412);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(86, 37);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(511, 416);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 31);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 465);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.pnlTrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Details";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.pnlTrip.ResumeLayout(false);
            this.pnlTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrip;
        private System.Windows.Forms.Label lbBooking;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbAccommodation;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbTour;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbTotalInfo;
        private System.Windows.Forms.Label lbStartInfo;
        private System.Windows.Forms.Label lbEndInfo;
        private System.Windows.Forms.Label lbAccInfo;
        private System.Windows.Forms.Label lbDesInfo;
        private System.Windows.Forms.Label lbPriceInfo;
        private System.Windows.Forms.Label lbTourInfo;
        private System.Windows.Forms.Label lbCapaInfo;
        private System.Windows.Forms.Label lbCapacity;
    }
}