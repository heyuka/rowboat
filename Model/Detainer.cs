using System;

namespace rowboat
{
    class Detainer
    {
        public Detainer()
        {
            this.numID = -1;
            this.sid = "";
            this.cid = "";
            this.referenceNo = "";
            this.dateEntered = DateTime.MinValue;
            this.agency = "";
            this.type = "";
            this.offense = "";
        }

        public Detainer(int numID, string sid, string cid, string referenceNo, DateTime dateEntered, string agency, char type, string offense)
        {
            this.numID = numID;
            this.sid = sid;
            this.cid = cid;
            this.referenceNo = referenceNo;
            this.dateEntered = dateEntered;
            this.agency = agency;
            this.type = type;
            this.offense = offense;
        }

        public int numID { get; set; }
        public string sid { get; set; }
        public string cid { get; set; }
        public string referenceNo { get; set; }
        public DateTime dateEntered { get; set; }
        public string agency { get; set; }
        public char type { get; set; }
        public string offense { get; set; }
    }
}