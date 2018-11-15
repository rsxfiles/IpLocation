using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Windows.Forms;

namespace IpLocation
{
    public partial class frmIpLookup : Form
    {
        /// <summary>
        /// Update the labels
        /// </summary>
        /// <param name="res"></param>
        public void UpdateLabels(Result res)
        {
            lblBusiness.Text = (res.businessName == "" ? "-" : res.businessName);
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
            lblWebsite.Text = (res.businessWebsite == "" ? "-" : res.businessWebsite);

            //Update Flag
            picFlag.ImageLocation = "https://www.countryflags.io/" + res.countryCode + "/flat/64.png";
            picFlag.Show();

            //Update Map
            // config map
            System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 0;
            gMapControl.MaxZoom = 24;
            gMapControl.Zoom = 12;
            
            if(res.lon != "" & res.lat!="") gMapControl.Position = new PointLatLng(double.Parse(res.lat), double.Parse(res.lon));

        }
        
        public frmIpLookup()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmIpLookup_Load(object sender, EventArgs e)
        {
            // Load the information about your IP 
            try
            {
                Result result = Search.MyIp();
                txtIp.Text = result.query;
                this.UpdateLabels(result);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
                       
            this.UpdateLabels(Search.LookupIp(txtIp.Text));
                        
            Cursor.Current = Cursors.Default;
        }
    }
}
