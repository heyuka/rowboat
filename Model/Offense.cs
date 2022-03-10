using System;

namespace rowboat
{
    class Offense
    {
        public Offense()
        {
            this.offenseCode = "";
            this.title = "";
            this.degree = "";
            this.isDW = false;
            this.statute = "";
            this.isMSEligible = false;
            this.causeNo = "";
            this.countNo = "";
            this.dateOffense = DateTime.MinValue;
            this.isCC = false;
            this.county = "";
            this.numYears = -1;
            this.numMonths = -1;
            this.numDays = -1;
            this.dateBegin = DateTime.MinValue;
            this.dateMinExp = DateTime.MinValue;
            this.dateMaxExp = DateTime.MinValue;
            this.dateParoleElig = DateTime.MinValue;
            this.dateSentenced = DateTime.MinValue;
            this.isHB1433 = false;
            this.isRestitution = false;
            this.offenseCIDNo = "";
            this.dateCTO = DateTime.MinValue;
            this.hasVIS = false;
            this.numVIS = -1;
        }

        public Offense(string offenseCode, string title, char degree, bool isDW, string statute, bool isMSEligible, string causeNo, string countNo, DateTime dateOffense, bool isCC, string county, int numYears, int numMonths, int numDays, DateTime dateBegin, DateTime dateMinExp, DateTime dateMaxExp, DateTime dateParoleElig, DateTime dateSentenced, bool isHB1433, bool isRestitution, string offenseCIDNo, DateTime dateCTO, bool hasVIS, int numVIS)
        {
            this.offenseCode = offenseCode;
            this.title = title;
            this.degree = degree;
            this.isDW = isDW;
            this.statute = statute;
            this.isMSEligible = isMSEligible;
            this.causeNo = causeNo;
            this.countNo = countNo;
            this.dateOffense = dateOffense;
            this.isCC = isCC;
            this.county = county;
            this.numYears = numYears;
            this.numMonths = numMonths;
            this.numDays = numDays;
            this.dateBegin = dateBegin;
            this.dateMinExp = dateMinExp;
            this.dateMaxExp = dateMaxExp;
            this.dateParoleElig = dateParoleElig;
            this.dateSentenced = dateSentenced;
            this.isHB1433 = isHB1433;
            this.isRestitution = isRestitution;
            this.offenseCIDNo = offenseCIDNo;
            this.dateCTO = dateCTO;
            this.hasVIS = hasVIS;
            this.numVIS = numVIS;
        }

        public string offenseCode { get; set; }
        public string title { get; set; }
        public char degree { get; set; }
        public bool isDW { get; set; }
        public string statute { get; set; }
        public bool isMSEligible { get; set; }
        public string causeNo { get; set; }
        public string countNo { get; set; }
        public DateTime dateOffense { get; set; }
        public bool isCC { get; set; } 
        public string county { get; set; }
        public int numYears { get; set; }
        public int numMonths { get; set; }
        public int numDays { get; set; }
        public DateTime dateBegin { get; set; }
        public DateTime dateMinExp { get; set; }
        public DateTime dateMaxExp { get; set; }
        public DateTime dateParoleElig { get; set; }
        public DateTime dateSentenced { get; set; }
        public bool isHB1433 { get; set; }
        public bool isRestitution { get; set; }
        public string offenseCIDNo { get; set; }
        public DateTime dateCTO { get; set; }
        public bool hasVIS { get; set; }
        public int numVIS { get; set; }
    }
}