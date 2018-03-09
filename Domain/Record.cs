using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Record
    {
        public String Source { get; set; }
        public int RecordId { get; set; }
        public int UserID { get; set; }
        //public GeoCoordinate Location = new GeoCoordinate();
        public int Mentions { get; set; }
        public int Retweets { get; set; }
        public DateTime Date { get; set; }
        public String[] Words { get; set; }
        public double Sentiment { get; set; }
        public double Objectivity { get; set; }
        public String HashTag { get; set; }
        public Uri Url { get; set; }
        public String Person { get; set; }


    }
}
