namespace IpLocation
{
    partial class frmIpLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIpLookup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblIpType = new System.Windows.Forms.Label();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblContinent = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.lblIsp = new System.Windows.Forms.Label();
            this.lblIpName = new System.Windows.Forms.Label();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gMapControl);
            this.panel1.Location = new System.Drawing.Point(328, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 200);
            this.panel1.TabIndex = 0;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(103, 93);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(161, 27);
            this.txtIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Lookup Geolocation";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(282, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Lookup IP";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(835, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP Type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Business:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Website:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "ISP: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Organization: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Country:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "Region:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "Continent:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Latitude:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Longitude:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.ForeColor = System.Drawing.Color.Silver;
            this.lblIp.Location = new System.Drawing.Point(130, 156);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(98, 21);
            this.lblIp.TabIndex = 18;
            this.lblIp.Text = "IP Address: ";
            // 
            // lblIpType
            // 
            this.lblIpType.AutoSize = true;
            this.lblIpType.ForeColor = System.Drawing.Color.Silver;
            this.lblIpType.Location = new System.Drawing.Point(130, 190);
            this.lblIpType.Name = "lblIpType";
            this.lblIpType.Size = new System.Drawing.Size(73, 21);
            this.lblIpType.TabIndex = 19;
            this.lblIpType.Text = "IP Type: ";
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.ForeColor = System.Drawing.Color.Silver;
            this.lblBusiness.Location = new System.Drawing.Point(130, 223);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(70, 21);
            this.lblBusiness.TabIndex = 20;
            this.lblBusiness.Text = "Business";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.ForeColor = System.Drawing.Color.Silver;
            this.lblWebsite.Location = new System.Drawing.Point(130, 250);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(76, 21);
            this.lblWebsite.TabIndex = 21;
            this.lblWebsite.Text = "Website:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.ForeColor = System.Drawing.Color.Silver;
            this.lblLatitude.Location = new System.Drawing.Point(130, 320);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(80, 21);
            this.lblLatitude.TabIndex = 22;
            this.lblLatitude.Text = "Latitude:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.ForeColor = System.Drawing.Color.Silver;
            this.lblLongitude.Location = new System.Drawing.Point(130, 353);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(93, 21);
            this.lblLongitude.TabIndex = 23;
            this.lblLongitude.Text = "Longitude:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.Silver;
            this.lblCity.Location = new System.Drawing.Point(527, 65);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 21);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City:";
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.ForeColor = System.Drawing.Color.Silver;
            this.lblContinent.Location = new System.Drawing.Point(129, 440);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(94, 21);
            this.lblContinent.TabIndex = 27;
            this.lblContinent.Text = "Continent:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.ForeColor = System.Drawing.Color.Silver;
            this.lblRegion.Location = new System.Drawing.Point(127, 408);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(68, 21);
            this.lblRegion.TabIndex = 26;
            this.lblRegion.Text = "Region:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.Silver;
            this.lblCountry.Location = new System.Drawing.Point(529, 96);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(77, 21);
            this.lblCountry.TabIndex = 25;
            this.lblCountry.Text = "Country:";
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.ForeColor = System.Drawing.Color.Silver;
            this.lblOrganization.Location = new System.Drawing.Point(452, 218);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(120, 21);
            this.lblOrganization.TabIndex = 30;
            this.lblOrganization.Text = "Organization: ";
            // 
            // lblIsp
            // 
            this.lblIsp.AutoSize = true;
            this.lblIsp.ForeColor = System.Drawing.Color.Silver;
            this.lblIsp.Location = new System.Drawing.Point(452, 185);
            this.lblIsp.Name = "lblIsp";
            this.lblIsp.Size = new System.Drawing.Size(40, 21);
            this.lblIsp.TabIndex = 29;
            this.lblIsp.Text = "ISP: ";
            // 
            // lblIpName
            // 
            this.lblIpName.AutoSize = true;
            this.lblIpName.ForeColor = System.Drawing.Color.Silver;
            this.lblIpName.Location = new System.Drawing.Point(452, 145);
            this.lblIpName.Name = "lblIpName";
            this.lblIpName.Size = new System.Drawing.Size(84, 21);
            this.lblIpName.TabIndex = 28;
            this.lblIpName.Text = "IP Name: ";
            // 
            // picFlag
            // 
            this.picFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFlag.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picFlag.ErrorImage")));
            this.picFlag.Location = new System.Drawing.Point(722, 37);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(110, 99);
            this.picFlag.TabIndex = 31;
            this.picFlag.TabStop = false;
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(0, 0);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(501, 199);
            this.gMapControl.TabIndex = 32;
            this.gMapControl.Zoom = 0D;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 492);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 165);
            this.dataGridView1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(26, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(32, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 36);
            this.button3.TabIndex = 34;
            this.button3.Text = "Del";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(32, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 36);
            this.button4.TabIndex = 35;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmIpLookup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(862, 685);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picFlag);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.lblIsp);
            this.Controls.Add(this.lblIpName);
            this.Controls.Add(this.lblContinent);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblBusiness);
            this.Controls.Add(this.lblIpType);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIpLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmIpLookup_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblIpType;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Label lblIsp;
        private System.Windows.Forms.Label lblIpName;
        private System.Windows.Forms.PictureBox picFlag;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

