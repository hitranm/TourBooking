
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lbTourID = new System.Windows.Forms.Label();
            this.txtTourID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(409, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(166, 88);
            this.txtTourName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.PlaceholderText = "Enter here..";
            this.txtTourName.Size = new System.Drawing.Size(217, 27);
            this.txtTourName.TabIndex = 2;
            // 
            // lbTourName
            // 
            this.lbTourName.AutoSize = true;
            this.lbTourName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourName.Location = new System.Drawing.Point(28, 92);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(100, 23);
            this.lbTourName.TabIndex = 3;
            this.lbTourName.Text = "Tour name :";
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDeparture.Location = new System.Drawing.Point(28, 154);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(96, 23);
            this.lbDeparture.TabIndex = 4;
            this.lbDeparture.Text = "Departure :";
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDestination.Location = new System.Drawing.Point(28, 219);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(106, 23);
            this.lbDestination.TabIndex = 5;
            this.lbDestination.Text = "Destination :";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.Location = new System.Drawing.Point(28, 281);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(105, 23);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Description :";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(166, 154);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.PlaceholderText = "Enter here..";
            this.txtDeparture.Size = new System.Drawing.Size(217, 27);
            this.txtDeparture.TabIndex = 7;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(166, 219);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.PlaceholderText = "Enter here...";
            this.txtDestination.Size = new System.Drawing.Size(214, 27);
            this.txtDestination.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(166, 281);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Enter here...";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(214, 105);
            this.txtDescription.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 476);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(28, 403);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(56, 20);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status :";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(166, 403);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(83, 24);
            this.cbStatus.TabIndex = 12;
            this.cbStatus.Text = "Active ?";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lbTourID
            // 
            this.lbTourID.AutoSize = true;
            this.lbTourID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourID.Location = new System.Drawing.Point(28, 26);
            this.lbTourID.Name = "lbTourID";
            this.lbTourID.Size = new System.Drawing.Size(74, 23);
            this.lbTourID.TabIndex = 13;
            this.lbTourID.Text = "Tour ID :";
            // 
            // txtTourID
            // 
            this.txtTourID.Location = new System.Drawing.Point(166, 26);
            this.txtTourID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTourID.Name = "txtTourID";
            this.txtTourID.ReadOnly = true;
            this.txtTourID.Size = new System.Drawing.Size(217, 27);
            this.txtTourID.TabIndex = 14;
            // 
            // frmAddNewTour
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 534);
            this.Controls.Add(this.txtTourID);
            this.Controls.Add(this.lbTourID);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.lbDeparture);
            this.Controls.Add(this.lbTourName);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddNewTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAddNewTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label lbTourID;
        private System.Windows.Forms.TextBox txtTourID;
    }
}