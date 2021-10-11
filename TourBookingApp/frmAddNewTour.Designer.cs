
namespace TourBookingApp
{
    partial class frmAddNewTour
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
            this.lbAddNewTour = new System.Windows.Forms.Label();
            this.btnAddNewTour = new System.Windows.Forms.Button();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtTourDeparture = new System.Windows.Forms.TextBox();
            this.txtTourDestination = new System.Windows.Forms.TextBox();
            this.txtTourDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbAddNewTour
            // 
            this.lbAddNewTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddNewTour.AutoSize = true;
            this.lbAddNewTour.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddNewTour.Location = new System.Drawing.Point(247, 74);
            this.lbAddNewTour.Name = "lbAddNewTour";
            this.lbAddNewTour.Size = new System.Drawing.Size(201, 32);
            this.lbAddNewTour.TabIndex = 0;
            this.lbAddNewTour.Text = "ADD NEW TOUR";
          
            // 
            // btnAddNewTour
            // 
            this.btnAddNewTour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewTour.Location = new System.Drawing.Point(423, 558);
            this.btnAddNewTour.Name = "btnAddNewTour";
            this.btnAddNewTour.Size = new System.Drawing.Size(85, 39);
            this.btnAddNewTour.TabIndex = 1;
            this.btnAddNewTour.Text = "Add";
            this.btnAddNewTour.UseVisualStyleBackColor = true;
            // 
            // txtTourName
            // 
            this.txtTourName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTourName.Location = new System.Drawing.Point(217, 191);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(268, 23);
            this.txtTourName.TabIndex = 2;
            // 
            // lbTourName
            // 
            this.lbTourName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTourName.AutoSize = true;
            this.lbTourName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourName.Location = new System.Drawing.Point(92, 192);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(77, 17);
            this.lbTourName.TabIndex = 3;
            this.lbTourName.Text = "Tour name :";
            // 
            // lbDeparture
            // 
            this.lbDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDeparture.Location = new System.Drawing.Point(92, 257);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(74, 17);
            this.lbDeparture.TabIndex = 4;
            this.lbDeparture.Text = "Departure :";
            // 
            // lbDestination
            // 
            this.lbDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDestination.AutoSize = true;
            this.lbDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDestination.Location = new System.Drawing.Point(93, 311);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(80, 17);
            this.lbDestination.TabIndex = 5;
            this.lbDestination.Text = "Destination :";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.Location = new System.Drawing.Point(93, 368);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(81, 17);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Description :";
            // 
            // txtTourDeparture
            // 
            this.txtTourDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTourDeparture.Location = new System.Drawing.Point(217, 256);
            this.txtTourDeparture.Name = "txtTourDeparture";
            this.txtTourDeparture.Size = new System.Drawing.Size(268, 23);
            this.txtTourDeparture.TabIndex = 7;
            // 
            // txtTourDestination
            // 
            this.txtTourDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTourDestination.Location = new System.Drawing.Point(217, 310);
            this.txtTourDestination.Name = "txtTourDestination";
            this.txtTourDestination.Size = new System.Drawing.Size(268, 23);
            this.txtTourDestination.TabIndex = 8;
            // 
            // txtTourDescription
            // 
            this.txtTourDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTourDescription.Location = new System.Drawing.Point(217, 367);
            this.txtTourDescription.Multiline = true;
            this.txtTourDescription.Name = "txtTourDescription";
            this.txtTourDescription.Size = new System.Drawing.Size(268, 80);
            this.txtTourDescription.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(544, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(93, 472);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(45, 15);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status :";
            
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(217, 471);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(67, 19);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.Text = "Active ?";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // frmAddNewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 631);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTourDescription);
            this.Controls.Add(this.txtTourDestination);
            this.Controls.Add(this.txtTourDeparture);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.lbDeparture);
            this.Controls.Add(this.lbTourName);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.btnAddNewTour);
            this.Controls.Add(this.lbAddNewTour);
            this.MaximumSize = new System.Drawing.Size(670, 670);
            this.MinimumSize = new System.Drawing.Size(670, 670);
            this.Name = "frmAddNewTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewTour";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddNewTour;
        private System.Windows.Forms.Button btnAddNewTour;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtTourDeparture;
        private System.Windows.Forms.TextBox txtTourDestination;
        private System.Windows.Forms.TextBox txtTourDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.CheckBox cbStatus;
    }
}