using System;

namespace rowboat
{
    public class Offender
    {
        public Offender()
        {
            this.cid = "";
            this.sid = "";
            this.name = "";
            this.numOffenses = -1;
            this.minExp = DateTime.MinValue;
            this.received = DateTime.MinValue;
            this.maxTermYears = -1;
            this.maxTermMonths = -1;
            this.maxTermDays = -1;
            this.maxDate = DateTime.MinValue;
            this.beginDate = DateTime.MinValue;
            this.parElig = DateTime.MinValue;
            this.isHB1433 = false;
            this.offenses = new List<Offense>();
            this.unitCode = "";
            this.race = "";
            this.heightFt = -1;
            this.heightIn = -1;
            this.weight = -1;
            this.status = "";
            this.custody = "";
            this.housing = "";
            this.job = "";
            this.dob = "";
            this.age = -1;
            this.numDetainers = -1;
            this.detainers = new List<Detainer>();
            this.history = new List<History>();
            this.workRestrictions = new string[]();
            this.pulhes = new string[]();
        }

        public Offender(string cid, string sid, string name, int numOffenses, DateTime minExp, DateTime received, int maxTermYears, int maxTermMonths, int maxTermDays, DateTime maxDate, DateTime beginDate, DateTime parElig, bool isHB1433, List<Offense> offenses, string unitCode, string race, int heightFt, int heightIn, int weight, string status, string custody, string housing, string job, DateTime dob, int age, int numDetainers, List<Detainer> detainers, List<History> history, string[] workRestrictions, string[] pulhes)
        {
            this.cid = cid;
            this.sid = sid;
            this.name = name;
            this.numOffenses = numOffenses;
            this.minExp = minExp;
            this.received = received;
            this.maxTermYears = maxTermYears;
            this.maxTermMonths = maxTermMonths;
            this.maxTermDays = maxTermDays;
            this.maxDate = maxDate;
            this.beginDate = beginDate;
            this.parElig = parElig;
            this.isHB1433 = isHB1433;
            this.offenses = offenses;
            this.unitCode = unitCode;
            this.race = race;
            this.heightFt = heightFt;
            this.heightIn = heightIn;
            this.weight = weight;
            this.status = status;
            this.custody = custody;
            this.housing = housing;
            this.job = job;
            this.dob = dob;
            this.age = age;
            this.numDetainers = numDetainers;
            this.detainers = detainers;
            this.history = history;
            this.workRestrictions = workRestrictions;
            this.pulhes = pulhes;
        }

        public string cid { get; set; }
        public string sid { get; set; }
        public string name { get; set; }
        public int numOffenses { get; set; }
        public DateTime minExp { get; set; }
        public DateTime received { get; set; }
        public int maxTermYears { get; set; }
        public int maxTermMonths { get; set; }
        public int maxTermDays { get; set; }
        public DateTime maxDate { get; set; }
        public DateTime beginDate { get; set; }
        public DateTime parElig { get; set; }
        public bool isHB1433 { get; set; }
        public List<Offense> offenses { get; set; }
        public string unitCode { get; set; }
        public string race { get; set; }
        public int heightFt { get; set; }
        public int heightIn { get; set; }
        public int weight { get; set; }
        public string status { get; set; }
        public string custody { get; set; }
        public string housing { get; set; }
        public string job { get; set; }
        public DateTime dob { get; set; }
        public int age { get; set; }
        public int numDetainers { get; set; }
        public List<Detainer> detainers { get; set; }
        public List<History> history { get; set; }
        public string[] workRestrictions { get; set; }
        public string[] pulhes { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {

            return $"{sid} {cid} {name, 30}";
        }
    }

}