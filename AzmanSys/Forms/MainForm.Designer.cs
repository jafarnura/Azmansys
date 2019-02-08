﻿namespace AzmanSys
{
    partial class MainForm
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
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageFlights = new System.Windows.Forms.Button();
            this.btnManageBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.ForeColor = System.Drawing.Color.DarkRed;
            this.btnManageCustomers.Location = new System.Drawing.Point(60, 82);
            this.btnManageCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(154, 112);
            this.btnManageCustomers.TabIndex = 0;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageFlights
            // 
            this.btnManageFlights.ForeColor = System.Drawing.Color.DarkRed;
            this.btnManageFlights.Location = new System.Drawing.Point(271, 82);
            this.btnManageFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageFlights.Name = "btnManageFlights";
            this.btnManageFlights.Size = new System.Drawing.Size(141, 112);
            this.btnManageFlights.TabIndex = 1;
            this.btnManageFlights.Text = "Manage Flights";
            this.btnManageFlights.UseVisualStyleBackColor = true;
            this.btnManageFlights.Click += new System.EventHandler(this.btnManageFlights_Click);
            // 
            // btnManageBookings
            // 
            this.btnManageBookings.ForeColor = System.Drawing.Color.DarkRed;
            this.btnManageBookings.Location = new System.Drawing.Point(462, 82);
            this.btnManageBookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageBookings.Name = "btnManageBookings";
            this.btnManageBookings.Size = new System.Drawing.Size(153, 112);
            this.btnManageBookings.TabIndex = 2;
            this.btnManageBookings.Text = "Manage Bookings";
            this.btnManageBookings.UseVisualStyleBackColor = true;
            this.btnManageBookings.Click += new System.EventHandler(this.btnManageBookings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(712, 302);
            this.Controls.Add(this.btnManageBookings);
            this.Controls.Add(this.btnManageFlights);
            this.Controls.Add(this.btnManageCustomers);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageFlights;
        private System.Windows.Forms.Button btnManageBookings;
    }
}

