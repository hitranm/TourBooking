
using System;
using System.Windows.Forms;

namespace TourBookingApp
{
    partial class frmManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TourManage = new System.Windows.Forms.TabPage();
            this.dtgListTour = new System.Windows.Forms.DataGridView();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchTour = new System.Windows.Forms.TextBox();
            this.TripManage = new System.Windows.Forms.TabPage();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.btnRefreshTrip = new System.Windows.Forms.Button();
            this.btnFindTrip = new System.Windows.Forms.Button();
            this.DTPFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.DTPFilterStart = new System.Windows.Forms.DateTimePicker();
            this.lbTripFilterByDate = new System.Windows.Forms.Label();
            this.lbTripFilterByStatus = new System.Windows.Forms.Label();
            this.cbxTripFilter = new System.Windows.Forms.ComboBox();
            this.dtgTripList = new System.Windows.Forms.DataGridView();
            this.btnDeleteTrip = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBooking = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.dgvSelectList = new System.Windows.Forms.DataGridView();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TourManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).BeginInit();
            this.TripManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).BeginInit();
            this.tabBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TourManage);
            this.tabControl1.Controls.Add(this.TripManage);
            this.tabControl1.Controls.Add(this.tabBooking);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 761);
            this.tabControl1.TabIndex = 0;
            // 
            // TourManage
            // 
            this.TourManage.Controls.Add(this.dtgListTour);
            this.TourManage.Controls.Add(this.btnDeleteTour);
            this.TourManage.Controls.Add(this.btnAddTour);
            this.TourManage.Controls.Add(this.btnSearch);
            this.TourManage.Controls.Add(this.txtSearchTour);
            this.TourManage.Location = new System.Drawing.Point(4, 29);
            this.TourManage.Name = "TourManage";
            this.TourManage.Padding = new System.Windows.Forms.Padding(3);
            this.TourManage.Size = new System.Drawing.Size(1293, 728);
            this.TourManage.TabIndex = 0;
            this.TourManage.Text = "Tour";
            this.TourManage.UseVisualStyleBackColor = true;
            // 
            // dtgListTour
            // 
            this.dtgListTour.AllowUserToAddRows = false;
            this.dtgListTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListTour.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgListTour.Location = new System.Drawing.Point(13, 152);
            this.dtgListTour.Name = "dtgListTour";
            this.dtgListTour.ReadOnly = true;
            this.dtgListTour.RowHeadersWidth = 51;
            this.dtgListTour.RowTemplate.Height = 25;
            this.dtgListTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListTour.Size = new System.Drawing.Size(1270, 516);
            this.dtgListTour.TabIndex = 18;
            this.dtgListTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListTour_CellClick);
            this.dtgListTour.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListTour_CellDoubleClick);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Location = new System.Drawing.Point(1061, 93);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(102, 53);
            this.btnDeleteTour.TabIndex = 17;
            this.btnDeleteTour.Text = "Delete";
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(933, 93);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(109, 53);
            this.btnAddTour.TabIndex = 16;
            this.btnAddTour.Text = "Add ";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(775, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 32);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchTour
            // 
            this.txtSearchTour.Location = new System.Drawing.Point(225, 20);
            this.txtSearchTour.Name = "txtSearchTour";
            this.txtSearchTour.PlaceholderText = "Enter tour name here...";
            this.txtSearchTour.Size = new System.Drawing.Size(519, 27);
            this.txtSearchTour.TabIndex = 19;
            // 
            // TripManage
            // 
            this.TripManage.Controls.Add(this.lbTo);
            this.TripManage.Controls.Add(this.lbFrom);
            this.TripManage.Controls.Add(this.btnRefreshTrip);
            this.TripManage.Controls.Add(this.btnFindTrip);
            this.TripManage.Controls.Add(this.DTPFilterEnd);
            this.TripManage.Controls.Add(this.DTPFilterStart);
            this.TripManage.Controls.Add(this.lbTripFilterByDate);
            this.TripManage.Controls.Add(this.lbTripFilterByStatus);
            this.TripManage.Controls.Add(this.cbxTripFilter);
            this.TripManage.Controls.Add(this.dtgTripList);
            this.TripManage.Controls.Add(this.btnDeleteTrip);
            this.TripManage.Controls.Add(this.btnAddTrip);
            this.TripManage.Location = new System.Drawing.Point(4, 29);
            this.TripManage.Name = "TripManage";
            this.TripManage.Padding = new System.Windows.Forms.Padding(3);
            this.TripManage.Size = new System.Drawing.Size(1293, 728);
            this.TripManage.TabIndex = 1;
            this.TripManage.Text = "Trip";
            this.TripManage.UseVisualStyleBackColor = true;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(358, 59);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(32, 20);
            this.lbTo.TabIndex = 33;
            this.lbTo.Text = "To :";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(10, 59);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(50, 20);
            this.lbFrom.TabIndex = 32;
            this.lbFrom.Text = "From :";
            // 
            // btnRefreshTrip
            // 
            this.btnRefreshTrip.Location = new System.Drawing.Point(216, 87);
            this.btnRefreshTrip.Name = "btnRefreshTrip";
            this.btnRefreshTrip.Size = new System.Drawing.Size(102, 31);
            this.btnRefreshTrip.TabIndex = 31;
            this.btnRefreshTrip.Text = "Refresh";
            this.btnRefreshTrip.UseVisualStyleBackColor = true;
            this.btnRefreshTrip.Click += new System.EventHandler(this.btnRefreshTrip_Click);
            // 
            // btnFindTrip
            // 
            this.btnFindTrip.Location = new System.Drawing.Point(64, 89);
            this.btnFindTrip.Name = "btnFindTrip";
            this.btnFindTrip.Size = new System.Drawing.Size(102, 31);
            this.btnFindTrip.TabIndex = 30;
            this.btnFindTrip.Text = "Find";
            this.btnFindTrip.UseVisualStyleBackColor = true;
            this.btnFindTrip.Click += new System.EventHandler(this.btnFindTrip_Click);
            // 
            // DTPFilterEnd
            // 
            this.DTPFilterEnd.Location = new System.Drawing.Point(393, 51);
            this.DTPFilterEnd.Name = "DTPFilterEnd";
            this.DTPFilterEnd.Size = new System.Drawing.Size(250, 27);
            this.DTPFilterEnd.TabIndex = 26;
            // 
            // DTPFilterStart
            // 
            this.DTPFilterStart.Location = new System.Drawing.Point(64, 51);
            this.DTPFilterStart.Name = "DTPFilterStart";
            this.DTPFilterStart.Size = new System.Drawing.Size(253, 27);
            this.DTPFilterStart.TabIndex = 25;
            // 
            // lbTripFilterByDate
            // 
            this.lbTripFilterByDate.AutoSize = true;
            this.lbTripFilterByDate.Location = new System.Drawing.Point(64, 27);
            this.lbTripFilterByDate.Name = "lbTripFilterByDate";
            this.lbTripFilterByDate.Size = new System.Drawing.Size(105, 20);
            this.lbTripFilterByDate.TabIndex = 24;
            this.lbTripFilterByDate.Text = "Filter by Date :";
            // 
            // lbTripFilterByStatus
            // 
            this.lbTripFilterByStatus.AutoSize = true;
            this.lbTripFilterByStatus.Location = new System.Drawing.Point(64, 143);
            this.lbTripFilterByStatus.Name = "lbTripFilterByStatus";
            this.lbTripFilterByStatus.Size = new System.Drawing.Size(113, 20);
            this.lbTripFilterByStatus.TabIndex = 23;
            this.lbTripFilterByStatus.Text = "Filter by Status :";
            // 
            // cbxTripFilter
            // 
            this.cbxTripFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTripFilter.FormattingEnabled = true;
            this.cbxTripFilter.Items.AddRange(new object[] {
            "Both",
            "Active",
            "Unactive"});
            this.cbxTripFilter.Location = new System.Drawing.Point(64, 169);
            this.cbxTripFilter.Name = "cbxTripFilter";
            this.cbxTripFilter.Size = new System.Drawing.Size(196, 28);
            this.cbxTripFilter.TabIndex = 22;
            this.cbxTripFilter.SelectedIndexChanged += new System.EventHandler(this.cbxTripFilter_SelectedIndexChanged);
            // 
            // dtgTripList
            // 
            this.dtgTripList.AllowUserToAddRows = false;
            this.dtgTripList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTripList.Location = new System.Drawing.Point(30, 217);
            this.dtgTripList.Name = "dtgTripList";
            this.dtgTripList.ReadOnly = true;
            this.dtgTripList.RowHeadersWidth = 51;
            this.dtgTripList.RowTemplate.Height = 25;
            this.dtgTripList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTripList.Size = new System.Drawing.Size(1235, 497);
            this.dtgTripList.TabIndex = 21;
            this.dtgTripList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTripList_CellClick);
            this.dtgTripList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTripList_CellDoubleClick);
            // 
            // btnDeleteTrip
            // 
            this.btnDeleteTrip.Location = new System.Drawing.Point(962, 143);
            this.btnDeleteTrip.Name = "btnDeleteTrip";
            this.btnDeleteTrip.Size = new System.Drawing.Size(102, 31);
            this.btnDeleteTrip.TabIndex = 20;
            this.btnDeleteTrip.Text = "Delete";
            this.btnDeleteTrip.UseVisualStyleBackColor = true;
            this.btnDeleteTrip.Click += new System.EventHandler(this.btnDeleteTrip_Click);
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(798, 143);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(102, 31);
            this.btnAddTrip.TabIndex = 19;
            this.btnAddTrip.Text = "Add";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.label1);
            this.tabBooking.Controls.Add(this.lbBooking);
            this.tabBooking.Controls.Add(this.btnCancelBooking);
            this.tabBooking.Controls.Add(this.dgvBooking);
            this.tabBooking.Controls.Add(this.dgvSelectList);
            this.tabBooking.Controls.Add(this.cboSelect);
            this.tabBooking.Location = new System.Drawing.Point(4, 29);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Size = new System.Drawing.Size(1293, 728);
            this.tabBooking.TabIndex = 2;
            this.tabBooking.Text = "Booking";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "*please select a specific booking";
            // 
            // lbBooking
            // 
            this.lbBooking.AutoSize = true;
            this.lbBooking.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBooking.Location = new System.Drawing.Point(837, 12);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(200, 32);
            this.lbBooking.TabIndex = 4;
            this.lbBooking.Text = "Booking History";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(1161, 3);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(75, 29);
            this.btnCancelBooking.TabIndex = 3;
            this.btnCancelBooking.Text = "Cancel";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(554, 55);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 25;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(728, 660);
            this.dgvBooking.TabIndex = 2;
            this.dgvBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellClick);
            // 
            // dgvSelectList
            // 
            this.dgvSelectList.AllowUserToAddRows = false;
            this.dgvSelectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectList.Location = new System.Drawing.Point(9, 55);
            this.dgvSelectList.Name = "dgvSelectList";
            this.dgvSelectList.ReadOnly = true;
            this.dgvSelectList.RowHeadersWidth = 51;
            this.dgvSelectList.RowTemplate.Height = 25;
            this.dgvSelectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectList.Size = new System.Drawing.Size(538, 660);
            this.dgvSelectList.TabIndex = 1;
            this.dgvSelectList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectList_CellDoubleClick);
            // 
            // cboSelect
            // 
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "Customer",
            "Trip"});
            this.cboSelect.Location = new System.Drawing.Point(8, 19);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(539, 28);
            this.cboSelect.TabIndex = 0;
            this.cboSelect.SelectedValueChanged += new System.EventHandler(this.cboSelect_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 38);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTour);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.lbTourName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(915, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTour
            // 
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(38, 203);
            this.dgvTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.RowTemplate.Height = 25;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(831, 283);
            this.dgvTour.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(486, 123);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 123);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 41);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 27);
            this.txtSearch.TabIndex = 14;
            // 
            // lbTourName
            // 
            this.lbTourName.AutoSize = true;
            this.lbTourName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourName.Location = new System.Drawing.Point(33, 22);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(116, 28);
            this.lbTourName.TabIndex = 13;
            this.lbTourName.Text = "Tour Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(915, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 204);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(831, 336);
            this.dataGridView2.TabIndex = 21;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 761);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmManagement_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.TourManage.ResumeLayout(false);
            this.TourManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).EndInit();
            this.TripManage.ResumeLayout(false);
            this.TripManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).EndInit();
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

       

        private System.Windows.Forms.TabPage TourManage;
        private System.Windows.Forms.DataGridView dtgListTour;
        private System.Windows.Forms.Button btnDeleteTour;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchTour;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.TabPage TripManage;
        private TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;       
        private System.Windows.Forms.TabPage tabPage2;
        private DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgTripList;
        private System.Windows.Forms.Button btnDeleteTrip;
        private System.Windows.Forms.Button btnAddTrip;

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridView dgvSelectList;
        private System.Windows.Forms.ComboBox cboSelect;
        private Label lbTripFilterByStatus;
        private ComboBox cbxTripFilter;
        private Label lbTripFilterByDate;
        private Button btnFindTrip;
        private DateTimePicker DTPFilterEnd;
        private DateTimePicker DTPFilterStart;
        private Button btnRefreshTrip;
        private Button btnCancelBooking;
        private Label lbBooking;
        private Label lbTo;
        private Label lbFrom;
        private Label label1;
    }
}
#endregion