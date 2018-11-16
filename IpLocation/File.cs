using System.Collections.Generic;

namespace IpLocation
{
    public class File
    {
        public List<Result> ListResult { get; set; }
        private List<string> _columns;
        
        public File()
        {
            _columns = new List<string>
            {  "businessName",
               "businessWebsite",
               "city",
               "continent",
               "country",
               "countryCode",
               "ipName",
               "ipType",
               "isp",
               "lat",
               "lon",
               "org",
               "query",
               "region",
               "status"
            };
        }

        public List<string> GetColumns() { return _columns; }

        //Save to CSV file
        public void SaveCSV()
        {

        }

        //Load from CSV file
        public List<Result> LoadCSV()
        {
            return new List<Result>();
        }
    }
}
