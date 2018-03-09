using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Item
    {
        public int ItemID { get; set; }
        public int ItemType { get; set; }
        public String Name { get; set; }
        public int Populariteit { get; set; }
        public int Vermelding { get; set; }
        public DateTime LatestRefresh { get; set; }

        private Item item { get; set; }


    }
}
