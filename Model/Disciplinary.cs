using System;

namespace rowboat
{
    class Disciplinary
    {
        public Disciplinary()
        {
            dateOffense = DateTime.MinValue;
            dateHearing = DateTime.MinValue;
            reportNo = "";
            code = "";
            level = "";
            grade = "";
            wasReprimanded = false;
            wasSolitary = false;
            classLost = "";
            timeLost = "";
            description = "";
        }

        public Disciplinary(DateTime dateOffense, DateTime dateHeating, string reportNo, string code, string level, string grade, bool wasReprimanded, bool wasSolitary, string classLost, string timeLost, string description)
        {
            this.dateOffense = dateOffense;
            this.dateHearing = dateHeating;
            this.reportNo = reportNo;
            this.code = code;
            this.level = level;
            this.grade = grade;
            this.wasReprimanded = wasReprimanded;
            this.wasSolitary = wasSolitary;
            this.classLost = classLost;
            this.timeLost = timeLost;
            this.description = description;
        }

        public DateTime dateOffense { get; set; }
        public DateTime dateHearing { get; set; }
        public string reportNo { get; set; }
        public string code { get; set; }
        public string level { get; set; }
        public string grade { get; set; }
        public bool wasReprimanded { get; set; }
        public bool wasSolitary { get; set; }
        public string classLost { get; set; }
        public string timeLost { get; set; }
        public string description { get; set; }
        
    }
}