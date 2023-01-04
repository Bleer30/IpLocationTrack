namespace IpLocationTrack
{
    partial class frmIpLocationTrack
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
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listIPLocation = new System.Windows.Forms.ListView();
            this.btnLoadLocationDetails = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(124, 42);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(170, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location:";
            // 
            // listIPLocation
            // 
            this.listIPLocation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listIPLocation.HideSelection = false;
            this.listIPLocation.Location = new System.Drawing.Point(53, 180);
            this.listIPLocation.Name = "listIPLocation";
            this.listIPLocation.Size = new System.Drawing.Size(299, 223);
            this.listIPLocation.TabIndex = 3;
            this.listIPLocation.UseCompatibleStateImageBehavior = false;
            this.listIPLocation.View = System.Windows.Forms.View.Details;
            // 
            // btnLoadLocationDetails
            // 
            this.btnLoadLocationDetails.Location = new System.Drawing.Point(102, 87);
            this.btnLoadLocationDetails.Name = "btnLoadLocationDetails";
            this.btnLoadLocationDetails.Size = new System.Drawing.Size(180, 23);
            this.btnLoadLocationDetails.TabIndex = 4;
            this.btnLoadLocationDetails.Text = "Load Location Details";
            this.btnLoadLocationDetails.UseVisualStyleBackColor = true;
            this.btnLoadLocationDetails.Click += new System.EventHandler(this.btnLoadLocationDetails_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 150;
            // 
            // frmIpLocationTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 444);
            this.Controls.Add(this.btnLoadLocationDetails);
            this.Controls.Add(this.listIPLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Name = "frmIpLocationTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track your IP Location!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listIPLocation;
        private System.Windows.Forms.Button btnLoadLocationDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

