﻿
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TourManage = new System.Windows.Forms.TabPage();
            this.dtgListTour = new System.Windows.Forms.DataGridView();
            this.btnDeleteTour = new System.Windows.Forms.Button();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchTour = new System.Windows.Forms.TextBox();
            this.lbTourName = new System.Windows.Forms.Label();
            this.TripManage = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtgTripList = new System.Windows.Forms.DataGridView();
            this.btnDeleteTrip = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TourManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).BeginInit();
            this.TripManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TourManage);
            this.tabControl1.Controls.Add(this.TripManage);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // TourManage
            // 
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.dgvTour);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnSearch);
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.TourManage.Controls.Add(this.dtgListTour);
            this.TourManage.Controls.Add(this.btnDeleteTour);
            this.TourManage.Controls.Add(this.btnAddTour);
            this.TourManage.Controls.Add(this.btnSearch);
            this.TourManage.Controls.Add(this.txtSearchTour);
            this.TourManage.Controls.Add(this.lbTourName);
            this.TourManage.Location = new System.Drawing.Point(4, 24);
            this.TourManage.Name = "TourManage";
            this.TourManage.Padding = new System.Windows.Forms.Padding(3);
            this.TourManage.Size = new System.Drawing.Size(800, 438);
            this.TourManage.TabIndex = 0;
            this.TourManage.Text = "Tour";
            this.TourManage.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // dtgListTour
            // 
            this.btnLoad.Location = new System.Drawing.Point(711, 25);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 41);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.dtgListTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListTour.Location = new System.Drawing.Point(33, 152);
            this.dtgListTour.Name = "dtgListTour";
            this.dtgListTour.ReadOnly = true;
            this.dtgListTour.RowHeadersWidth = 51;
            this.dtgListTour.RowTemplate.Height = 25;
            this.dtgListTour.Size = new System.Drawing.Size(727, 252);
            this.dtgListTour.TabIndex = 18;
            this.dtgListTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListTour_CellClick);
            // 
            // btnDeleteTour
            // dgvTour
            // 
            this.btnDeleteTour.Location = new System.Drawing.Point(425, 92);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(72, 31);
            this.btnDeleteTour.TabIndex = 17;
            this.btnDeleteTour.Text = "Delete";
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(38, 203);
            this.dgvTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.RowHeadersWidth = 51;
            this.dgvTour.RowTemplate.Height = 25;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(831, 283);
            this.dgvTour.TabIndex = 18;
            this.dgvTour.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellDoubleClick);
            // 
            // btnAddTour
            // btnDelete
            // 
            this.btnAddTour.Location = new System.Drawing.Point(225, 92);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(72, 31);
            this.btnAddTour.TabIndex = 16;
            this.btnAddTour.Text = "Add ";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(486, 123);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 41);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // btnAdd
            // 
            this.btnSearch.Location = new System.Drawing.Point(519, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 31);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnAdd.Location = new System.Drawing.Point(257, 123);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 41);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearchTour
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(593, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 41);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearchTour.Location = new System.Drawing.Point(168, 24);
            this.txtSearchTour.Name = "txtSearchTour";
            this.txtSearchTour.Size = new System.Drawing.Size(302, 23);
            this.txtSearchTour.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 27);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbTourName
            // 
            this.lbTourName.AutoSize = true;
            this.lbTourName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourName.Location = new System.Drawing.Point(33, 22);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(93, 21);
            this.lbTourName.TabIndex = 13;
            this.lbTourName.Text = "Tour Name :";
            // 
            // TripManage
            // 
            this.TripManage.Controls.Add(this.btnRefresh);
            this.TripManage.Controls.Add(this.dtgTripList);
            this.TripManage.Controls.Add(this.btnDeleteTrip);
            this.TripManage.Controls.Add(this.btnAddTrip);
            this.TripManage.Controls.Add(this.label5);
            this.TripManage.Controls.Add(this.label4);
            this.TripManage.Controls.Add(this.label3);
            this.TripManage.Controls.Add(this.label2);
            this.TripManage.Location = new System.Drawing.Point(4, 24);
            this.TripManage.Name = "TripManage";
            this.TripManage.Padding = new System.Windows.Forms.Padding(3);
            this.TripManage.Size = new System.Drawing.Size(800, 438);
            this.TripManage.TabIndex = 1;
            this.TripManage.Text = "Trip";
            this.TripManage.UseVisualStyleBackColor = true;
            this.lbTourName.AutoSize = true;
            this.lbTourName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTourName.Location = new System.Drawing.Point(38, 29);
            this.lbTourName.Name = "lbTourName";
            this.lbTourName.Size = new System.Drawing.Size(116, 28);
            this.lbTourName.TabIndex = 13;
            this.lbTourName.Text = "Tour Name :";
            this.lbTourName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(33, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label6);
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
            // dtgTripList
            // 
            this.dtgTripList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTripList.Location = new System.Drawing.Point(32, 100);
            this.dtgTripList.Name = "dtgTripList";
            this.dtgTripList.ReadOnly = true;
            this.dtgTripList.RowHeadersWidth = 51;
            this.dtgTripList.RowTemplate.Height = 25;
            this.dtgTripList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTripList.Size = new System.Drawing.Size(727, 305);
            this.dtgTripList.TabIndex = 21;
            
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 204);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(831, 336);
            this.dataGridView2.TabIndex = 21;
            this.dtgTripList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTripList_CellDoubleClick);
            // 
            // btnDeleteTrip
            // 
            this.button6.Location = new System.Drawing.Point(603, 42);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Location = new System.Drawing.Point(498, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 29);
            this.button6.TabIndex = 20;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.btnDeleteTrip.Location = new System.Drawing.Point(603, 42);
            this.btnDeleteTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTrip.Name = "btnDeleteTrip";
            this.btnDeleteTrip.Size = new System.Drawing.Size(80, 22);
            this.btnDeleteTrip.TabIndex = 20;
            this.btnDeleteTrip.Text = "Delete";
            this.btnDeleteTrip.UseVisualStyleBackColor = true;
            this.btnDeleteTrip.Click += new System.EventHandler(this.btnDeleteTrip_Click);
            // 
            // btnAddTrip
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(436, 27);
            this.textBox3.TabIndex = 17;
            // 
            // label6
            this.textBox3.TabIndex = 17;
            this.btnAddTrip.Location = new System.Drawing.Point(433, 42);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(82, 22);
            this.btnAddTrip.TabIndex = 19;
            this.btnAddTrip.Text = "Add";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trip Name :";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trip Name :";
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
            // tabPage3
            // 
            this.tabPage3.Size = new System.Drawing.Size(800, 438);
            this.tabPage3.Size = new System.Drawing.Size(915, 588);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Booking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 621);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TourManage.ResumeLayout(false);
            this.TourManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).EndInit();
            this.TripManage.ResumeLayout(false);
            this.TripManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbTourName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgTripList;
        private System.Windows.Forms.Button btnDeleteTrip;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}