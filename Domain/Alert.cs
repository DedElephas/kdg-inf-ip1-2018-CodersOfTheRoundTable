using System;

namespace Domain
{
    public class Alert
    {
        public int AlertID { get; set; }
        public double AbsoluteVerandering { get; set; }
        public int RelatieveVerandering { get; set; }

        private Alert alert { get; set; };

       
    }
}
