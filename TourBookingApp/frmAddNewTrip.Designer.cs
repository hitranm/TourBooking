
namespace TourBookingApp
{
    partial class frmAddNewTrip
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
            this.lbTripName = new System.Windows.Forms.Label();
            this.lbAddNewTrip = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbAccommodation = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtAccommodation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.DTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.NUDCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbxListTourName = new System.Windows.Forms.ComboBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.mtxtPrice = new System.Windows.Forms.MaskedTextBox();
            this.lbTripId = new System.Windows.Forms.Label();
            this.txtTripID = new System.Windows.Forms.TextBox();
            this.cbTripStatus = new System.Windows.Forms.CheckBox();
            this.lbTripStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTripName
            // 
            this.lbTripName.AutoSize = true;
            this.lbTripName.Location = new System.Drawing.Point(95, 172);
            this.lbTripName.Name = "lbTripName";
            this.lbTripName.Size = new System.Drawing.Size(45, 20);
            this.lbTripName.TabIndex = 0;
            this.lbTripName.Text = "Tour :";
            // 
            // lbAddNewTrip
            // 
            this.lbAddNewTrip.AutoSize = true;
            this.lbAddNewTrip.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddNewTrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAddNewTrip.Location = new System.Drawing.Point(211, 12);
            this.lbAddNewTrip.Name = "lbAddNewTrip";
            this.lbAddNewTrip.Size = new System.Drawing.Size(234, 38);
            this.lbAddNewTrip.TabIndex = 2;
            this.lbAddNewTrip.Text = "Trip Information";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(95, 223);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(74, 20);
            this.lbStartTime.TabIndex = 3;
            this.lbStartTime.Text = "Start time";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Location = new System.Drawing.Point(95, 279);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(71, 20);
            this.lbEndTime.TabIndex = 4;
            this.lbEndTime.Text = "End Time";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(95, 392);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(66, 20);
            this.lbCapacity.TabIndex = 5;
            this.lbCapacity.Text = "Capacity";
            // 
            // lbAccommodation
            // 
            this.lbAccommodation.AutoSize = true;
            this.lbAccommodation.Location = new System.Drawing.Point(95, 456);
            this.lbAccommodation.Name = "lbAccommodation";
            this.lbAccommodation.Size = new System.Drawing.Size(120, 20);
            this.lbAccommodation.TabIndex = 6;
            this.lbAccommodation.Text = "Accommodation";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(95, 520);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Description";
            // 
            // txtAccommodation
            // 
            this.txtAccommodation.Location = new System.Drawing.Point(262, 452);
            this.txtAccommodation.Name = "txtAccommodation";
            this.txtAccommodation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAccommodation.Size = new System.Drawing.Size(292, 27);
            this.txtAccommodation.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(262, 516);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(292, 88);
            this.txtDescription.TabIndex = 12;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrip.Location = new System.Drawing.Point(311, 692);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(94, 29);
            this.btnAddTrip.TabIndex = 13;
            this.btnAddTrip.Text = "Save";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(435, 692);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DTPStartTime
            // 
            this.DTPStartTime.Location = new System.Drawing.Point(262, 215);
            this.DTPStartTime.Name = "DTPStartTime";
            this.DTPStartTime.Size = new System.Drawing.Size(292, 27);
            this.DTPStartTime.TabIndex = 15;
            // 
            // DTPEndTime
            // 
            this.DTPEndTime.Location = new System.Drawing.Point(262, 271);
            this.DTPEndTime.Name = "DTPEndTime";
            this.DTPEndTime.Size = new System.Drawing.Size(292, 27);
            this.DTPEndTime.TabIndex = 16;
            // 
            // NUDCapacity
            // 
            this.NUDCapacity.Location = new System.Drawing.Point(262, 389);
            this.NUDCapacity.Name = "NUDCapacity";
            this.NUDCapacity.Size = new System.Drawing.Size(293, 27);
            this.NUDCapacity.TabIndex = 17;
            this.NUDCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxListTourName
            // 
            this.cbxListTourName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListTourName.FormattingEnabled = true;
            this.cbxListTourName.Location = new System.Drawing.Point(262, 161);
            this.cbxListTourName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxListTourName.Name = "cbxListTourName";
            this.cbxListTourName.Size = new System.Drawing.Size(292, 28);
            this.cbxListTourName.TabIndex = 18;
            this.cbxListTourName.SelectedValueChanged += new System.EventHandler(this.cbxListTourName_SelectedValueChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(95, 332);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 20);
            this.lbPrice.TabIndex = 20;
            this.lbPrice.Text = "Price";
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.Location = new System.Drawing.Point(262, 332);
            this.mtxtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtPrice.Mask = "0000000000";
            this.mtxtPrice.Name = "mtxtPrice";
            this.mtxtPrice.Size = new System.Drawing.Size(292, 27);
            this.mtxtPrice.TabIndex = 21;
            this.mtxtPrice.ValidatingType = typeof(int);
            // 
            // lbTripId
            // 
            this.lbTripId.AutoSize = true;
            this.lbTripId.Location = new System.Drawing.Point(95, 116);
            this.lbTripId.Name = "lbTripId";
            this.lbTripId.Size = new System.Drawing.Size(31, 20);
            this.lbTripId.TabIndex = 22;
            this.lbTripId.Text = "ID :";
            // 
            // txtTripID
            // 
            this.txtTripID.Enabled = false;
            this.txtTripID.Location = new System.Drawing.Point(262, 105);
            this.txtTripID.Name = "txtTripID";
            this.txtTripID.Size = new System.Drawing.Size(292, 27);
            this.txtTripID.TabIndex = 23;
            // 
            // cbTripStatus
            // 
            this.cbTripStatus.AutoSize = true;
            this.cbTripStatus.Location = new System.Drawing.Point(262, 625);
            this.cbTripStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTripStatus.Name = "cbTripStatus";
            this.cbTripStatus.Size = new System.Drawing.Size(83, 24);
            this.cbTripStatus.TabIndex = 24;
            this.cbTripStatus.Text = "Active ?";
            this.cbTripStatus.UseVisualStyleBackColor = true;
            // 
            // lbTripStatus
            // 
            this.lbTripStatus.AutoSize = true;
            this.lbTripStatus.Location = new System.Drawing.Point(95, 627);
            this.lbTripStatus.Name = "lbTripStatus";
            this.lbTripStatus.Size = new System.Drawing.Size(49, 20);
            this.lbTripStatus.TabIndex = 25;
            this.lbTripStatus.Text = "Status";
            // 
            // frmAddNewTrip
            // 
            this.AcceptButton = this.btnAddTrip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 737);
            this.Controls.Add(this.lbTripStatus);
            this.Controls.Add(this.cbTripStatus);
            this.Controls.Add(this.txtTripID);
            this.Controls.Add(this.lbTripId);
            this.Controls.Add(this.mtxtPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cbxListTourName);
            this.Controls.Add(this.NUDCapacity);
            this.Controls.Add(this.DTPEndTime);
            this.Controls.Add(this.DTPStartTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAccommodation);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbAccommodation);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbEndTime);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.lbAddNewTrip);
            this.Controls.Add(this.lbTripName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(660, 784);
            this.MinimumSize = new System.Drawing.Size(650, 647);
            this.Name = "frmAddNewTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Trip ";
            this.Load += new System.EventHandler(this.frmAddNewTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTripName;
        private System.Windows.Forms.Label lbAddNewTrip;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label lbAccommodation;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtAccommodation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker DTPStartTime;
        private System.Windows.Forms.DateTimePicker DTPEndTime;
        private System.Windows.Forms.NumericUpDown NUDCapacity;
        private System.Windows.Forms.ComboBox cbxListTourName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.MaskedTextBox mtxtPrice;
        private System.Windows.Forms.Label lbTripId;
        private System.Windows.Forms.TextBox txtTripID;
        private System.Windows.Forms.CheckBox cbTripStatus;
        private System.Windows.Forms.Label lbTripStatus;
    }
}