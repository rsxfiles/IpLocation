using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChoETL;
using System.IO;

namespace IpLocation
{
    public partial class frmIpLookup : Form
    {

        Result _result;
        List<Result> _listGridview = new List<Result>();
        /// <summary>
        /// Update the labels
        /// </summary>
        /// <param name="res"></param>
        public void UpdateForm(Result res)
        {
            lblBusiness.Text = (res.businessName == "" ? "-" : res.businessName);
            lblWebsite.Text = (res.businessWebsite == "" ? "-" : res.businessWebsite);
            lblCity.Text = (res.city == "" ? "-" : res.city); 
            lblContinent.Text = (res.continent == "" ? "-" : res.continent); 
            lblCountry.Text = (res.country == "" ? "-" : res.country);
            lblIp.Text = res.query;
            lblIpName.Text = (res.ipName == "" ? "-" : res.ipName);
            lblIpType.Text = (res.ipType == "" ? "-" : res.ipType);
            lblIsp.Text = (res.isp == "" ? "-" : res.isp);
            lblLatitude.Text = (res.lat == "" ? "-" : res.lat);
            lblLongitude.Text = (res.lon == "" ? "-" : res.lon);
            lblOrganization.Text = (res.org == "" ? "-" : res.org);
            lblRegion.Text = (res.region == "" ? "-" : res.region);
            

            //Update Flag
            picFlag.ImageLocation = "https://www.countryflags.io/" + res.countryCode + "/flat/64.png";
            picFlag.Show();

            
            //Config map
            System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 12;

            //Update Map
            if (res.lon != "" & res.lat!="") gMapControl.Position = new PointLatLng(double.Parse(res.lat), double.Parse(res.lon));
        }

        public void LoadCSV()
        {
            using (StreamReader sr = new StreamReader("data.csv"))
            {
                string currentLine;
                // currentLine will be null when the StreamReader reaches the end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    var array = currentLine.Split(',');
                    _listGridview.Add(new Result
                    {
                        businessName = array[0],
                        businessWebsite = array[1],
                        city = array[2],
                        continent = array[3],
                        country = array[4],
                        countryCode = array[5],
                        ipName = array[6],
                        ipType = array[7],
                        isp = array[8],
                        lat = array[9],
                        lon = array[10],
                        org = array[11],
                        query = array[12],
                        region = array[13],
                        status = array[14]
                    });
                }
            }
            //Define columns for GridView and load data;
            dgvFile.DataSource = null;
            dgvFile.DataSource = this._listGridview;
        }
        
        public frmIpLookup()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIpLookup_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Load the information about your IP 
            try
            {
                this._result = Search.MyIp();
                txtIp.Text = this._result.query;
                this.UpdateForm(this._result);
                this.LoadCSV();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this._result = Search.LookupIp(txtIp.Text);
            this.UpdateForm(this._result);
                        
            Cursor.Current = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _listGridview.Add(this._result);
            dgvFile.DataSource = null;
            dgvFile.DataSource = this._listGridview;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvFile.SelectedRows.Count > 0)
            {
                int x = this.dgvFile.SelectedRows[0].Index;
                _listGridview.RemoveAt(x);
                dgvFile.DataSource = null;
                dgvFile.DataSource = this._listGridview;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIp.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (this.dgvFile.Rows.Count > 0)
            {
                using (var parser = new ChoCSVWriter("data.csv"))
                {
                    parser.Write(this._listGridview);
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
