﻿
namespace TourBookingApp
{
    partial class frmMain
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbTripList = new System.Windows.Forms.Label();
            this.dtgTripList = new System.Windows.Forms.DataGridView();
            this.btnManage = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.txtTourID = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDepart = new System.Windows.Forms.Label();
            this.lbDescript = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbTourList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgTourList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTourList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1366, 512);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 29);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbTripList
            // 
            this.lbTripList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTripList.AutoSize = true;
            this.lbTripList.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTripList.Location = new System.Drawing.Point(999, 9);
            this.lbTripList.Name = "lbTripList";
            this.lbTripList.Size = new System.Drawing.Size(67, 38);
            this.lbTripList.TabIndex = 15;
            this.lbTripList.Text = "Trip";
            // 
            // dtgTripList
            // 
            this.dtgTripList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTripList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTripList.Location = new System.Drawing.Point(586, 71);
            this.dtgTripList.Name = "dtgTripList";
            this.dtgTripList.RowHeadersWidth = 51;
            this.dtgTripList.RowTemplate.Height = 29;
            this.dtgTripList.Size = new System.Drawing.Size(884, 429);
            this.dtgTripList.TabIndex = 16;
            // 
            // btnManage
            // 
            this.btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManage.Location = new System.Drawing.Point(1266, 512);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(94, 29);
            this.btnManage.TabIndex = 15;
            this.btnManage.Text = "&Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDestination.Location = new System.Drawing.Point(366, 108);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(164, 27);
            this.txtDestination.TabIndex = 5;
            // 
            // txtTourName
            // 
            this.txtTourName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTourName.Location = new System.Drawing.Point(366, 62);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.ReadOnly = true;
            this.txtTourName.Size = new System.Drawing.Size(164, 27);
            this.txtTourName.TabIndex = 4;
            // 
            // txtTourID
            // 
            this.txtTourID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTourID.Location = new System.Drawing.Point(103, 62);
            this.txtTourID.Name = "txtTourID";
            this.txtTourID.ReadOnly = true;
            this.txtTourID.Size = new System.Drawing.Size(149, 27);
            this.txtTourID.TabIndex = 3;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDeparture.Location = new System.Drawing.Point(103, 108);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.ReadOnly = true;
            this.txtDeparture.Size = new System.Drawing.Size(149, 27);
            this.txtDeparture.TabIndex = 6;
            // 
            // lbDes
            // 
            this.lbDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDes.AutoSize = true;
            this.lbDes.Location = new System.Drawing.Point(269, 111);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(85, 20);
            this.lbDes.TabIndex = 7;
            this.lbDes.Text = "Destination";
            // 
            // lbID
            // 
            this.lbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(11, 65);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(57, 20);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "Tour ID";
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(269, 65);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 20);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Tour Name";
            // 
            // lbDepart
            // 
            this.lbDepart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDepart.AutoSize = true;
            this.lbDepart.Location = new System.Drawing.Point(11, 111);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(76, 20);
            this.lbDepart.TabIndex = 10;
            this.lbDepart.Text = "Departure";
            // 
            // lbDescript
            // 
            this.lbDescript.AutoSize = true;
            this.lbDescript.Location = new System.Drawing.Point(11, 170);
            this.lbDescript.Name = "lbDescript";
            this.lbDescript.Size = new System.Drawing.Size(85, 20);
            this.lbDescript.TabIndex = 11;
            this.lbDescript.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(103, 170);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(427, 73);
            this.txtDescription.TabIndex = 12;
            // 
            // lbTourList
            // 
            this.lbTourList.AutoSize = true;
            this.lbTourList.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTourList.Location = new System.Drawing.Point(225, 2);
            this.lbTourList.Name = "lbTourList";
            this.lbTourList.Size = new System.Drawing.Size(75, 38);
            this.lbTourList.TabIndex = 14;
            this.lbTourList.Text = "Tour";
            this.lbTourList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(436, 262);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.dtgTourList);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbTourList);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lbDescript);
            this.panel1.Controls.Add(this.lbDepart);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.lbDes);
            this.panel1.Controls.Add(this.txtDeparture);
            this.panel1.Controls.Add(this.txtTourID);
            this.panel1.Controls.Add(this.txtTourName);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 556);
            this.panel1.TabIndex = 2;
            // 
            // dtgTourList
            // 
            this.dtgTourList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTourList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTourList.Location = new System.Drawing.Point(3, 307);
            this.dtgTourList.MultiSelect = false;
            this.dtgTourList.Name = "dtgTourList";
            this.dtgTourList.RowHeadersWidth = 51;
            this.dtgTourList.RowTemplate.Height = 29;
            this.dtgTourList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTourList.Size = new System.Drawing.Size(524, 232);
            this.dtgTourList.TabIndex = 17;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.dtgTripList);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.lbTripList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.MaximumSize = new System.Drawing.Size(1500, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Group 3";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTourList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbTripList;
        private System.Windows.Forms.DataGridView dtgTripList;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.TextBox txtTourID;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDepart;
        private System.Windows.Forms.Label lbDescript;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Label lbTourList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgTourList;
    }
}