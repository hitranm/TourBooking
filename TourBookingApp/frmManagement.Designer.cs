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
            this.TourManage = new System.Windows.Forms.TabPage();
            this.dtgListTour = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TripManage = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtgTripList = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // TourManage
            // 
            this.TourManage.Controls.Add(this.dtgListTour);
            this.TourManage.Controls.Add(this.button3);
            this.TourManage.Controls.Add(this.btnAddTour);
            this.TourManage.Controls.Add(this.button1);
            this.TourManage.Controls.Add(this.textBox1);
            this.TourManage.Controls.Add(this.label1);
            this.TourManage.Location = new System.Drawing.Point(4, 24);
            this.TourManage.Name = "TourManage";
            this.TourManage.Padding = new System.Windows.Forms.Padding(3);
            this.TourManage.Size = new System.Drawing.Size(800, 438);
            this.TourManage.TabIndex = 0;
            this.TourManage.Text = "Tour";
            this.TourManage.UseVisualStyleBackColor = true;
            this.TourManage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dtgListTour
            // 
            this.dtgListTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListTour.Location = new System.Drawing.Point(33, 152);
            this.dtgListTour.Name = "dtgListTour";
            this.dtgListTour.ReadOnly = true;
            this.dtgListTour.RowHeadersWidth = 51;
            this.dtgListTour.RowTemplate.Height = 25;
            this.dtgListTour.Size = new System.Drawing.Size(727, 252);
            this.dtgListTour.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(225, 92);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(72, 31);
            this.btnAddTour.TabIndex = 16;
            this.btnAddTour.Text = "Add ";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tour Name :";
            // 
            // TripManage
            // 
            this.TripManage.Controls.Add(this.btnRefresh);
            this.TripManage.Controls.Add(this.dtgTripList);
            this.TripManage.Controls.Add(this.button6);
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
            this.dtgTripList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTripList_CellContentClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(603, 42);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 22);
            this.button6.TabIndex = 20;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Location = new System.Drawing.Point(433, 42);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(82, 22);
            this.btnAddTrip.TabIndex = 19;
            this.btnAddTrip.Text = "Add";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 14;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(51, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 2;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(800, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Booking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.TourManage.ResumeLayout(false);
            this.TourManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).EndInit();
            this.TripManage.ResumeLayout(false);
            this.TripManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTripList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TourManage;
        private System.Windows.Forms.DataGridView dtgListTour;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddTour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TripManage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgTripList;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnRefresh;
    }
}