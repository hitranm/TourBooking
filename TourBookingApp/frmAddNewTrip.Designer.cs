
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
            this.nameOfTrip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccomodation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.DTPEndTime = new System.Windows.Forms.DateTimePicker();
            this.NUDCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbxListTourName = new System.Windows.Forms.ComboBox();
            this.btnLoadTourName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtPrice = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTripName
            // 
            this.lbTripName.AutoSize = true;
            this.lbTripName.Location = new System.Drawing.Point(91, 110);
            this.lbTripName.Name = "lbTripName";
            this.lbTripName.Size = new System.Drawing.Size(36, 15);
            this.lbTripName.TabIndex = 0;
            this.lbTripName.Text = "Tour :";
            this.lbTripName.Click += new System.EventHandler(this.lbTripName_Click);
            // 
            // nameOfTrip
            // 
            this.nameOfTrip.AutoSize = true;
            this.nameOfTrip.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameOfTrip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameOfTrip.Location = new System.Drawing.Point(240, 22);
            this.nameOfTrip.Name = "nameOfTrip";
            this.nameOfTrip.Size = new System.Drawing.Size(114, 30);
            this.nameOfTrip.TabIndex = 2;
            this.nameOfTrip.Text = "ADD TRIP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accomodation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // txtAccomodation
            // 
            this.txtAccomodation.Location = new System.Drawing.Point(237, 320);
            this.txtAccomodation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccomodation.Name = "txtAccomodation";
            this.txtAccomodation.Size = new System.Drawing.Size(256, 23);
            this.txtAccomodation.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(237, 368);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(256, 67);
            this.txtDescription.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(272, 469);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(381, 469);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DTPStartTime
            // 
            this.DTPStartTime.Location = new System.Drawing.Point(240, 142);
            this.DTPStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPStartTime.Name = "DTPStartTime";
            this.DTPStartTime.Size = new System.Drawing.Size(253, 23);
            this.DTPStartTime.TabIndex = 15;
            // 
            // DTPEndTime
            // 
            this.DTPEndTime.Location = new System.Drawing.Point(240, 184);
            this.DTPEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPEndTime.Name = "DTPEndTime";
            this.DTPEndTime.Size = new System.Drawing.Size(253, 23);
            this.DTPEndTime.TabIndex = 16;
            // 
            // NUDCapacity
            // 
            this.NUDCapacity.Location = new System.Drawing.Point(237, 273);
            this.NUDCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUDCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDCapacity.Name = "NUDCapacity";
            this.NUDCapacity.Size = new System.Drawing.Size(256, 23);
            this.NUDCapacity.TabIndex = 17;
            this.NUDCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxListTourName
            // 
            this.cbxListTourName.FormattingEnabled = true;
            this.cbxListTourName.Location = new System.Drawing.Point(240, 102);
            this.cbxListTourName.Name = "cbxListTourName";
            this.cbxListTourName.Size = new System.Drawing.Size(253, 23);
            this.cbxListTourName.TabIndex = 18;
            this.cbxListTourName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbxListTourName.SelectedValueChanged += new System.EventHandler(this.cbxListTourName_SelectedValueChanged);
            // 
            // btnLoadTourName
            // 
            this.btnLoadTourName.Location = new System.Drawing.Point(415, 73);
            this.btnLoadTourName.Name = "btnLoadTourName";
            this.btnLoadTourName.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTourName.TabIndex = 19;
            this.btnLoadTourName.Text = "Load Tour";
            this.btnLoadTourName.UseVisualStyleBackColor = true;
            this.btnLoadTourName.Click += new System.EventHandler(this.btnLoadTourName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            // 
            // mtxtPrice
            // 
            this.mtxtPrice.Location = new System.Drawing.Point(237, 230);
            this.mtxtPrice.Mask = "0000000000";
            this.mtxtPrice.Name = "mtxtPrice";
            this.mtxtPrice.Size = new System.Drawing.Size(256, 23);
            this.mtxtPrice.TabIndex = 21;
            this.mtxtPrice.ValidatingType = typeof(int);
            // 
            // frmAddNewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 511);
            this.Controls.Add(this.mtxtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoadTourName);
            this.Controls.Add(this.cbxListTourName);
            this.Controls.Add(this.NUDCapacity);
            this.Controls.Add(this.DTPEndTime);
            this.Controls.Add(this.DTPStartTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAccomodation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOfTrip);
            this.Controls.Add(this.lbTripName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(571, 550);
            this.MinimumSize = new System.Drawing.Size(571, 497);
            this.Name = "frmAddNewTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Trip ";
            ((System.ComponentModel.ISupportInitialize)(this.NUDCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTripName;
        private System.Windows.Forms.Label nameOfTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccomodation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker DTPStartTime;
        private System.Windows.Forms.DateTimePicker DTPEndTime;
        private System.Windows.Forms.NumericUpDown NUDCapacity;
        private System.Windows.Forms.ComboBox cbxListTourName;
        private System.Windows.Forms.Button btnLoadTourName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtPrice;
    }
}