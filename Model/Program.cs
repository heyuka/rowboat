using System;

namespace rowboat
{
    class Program   
    {
        public Program()
        {
            name = "";
            isAP = "";
            entryDate = DateTime.MinValue;
            needCode = "";
            participationCode = "";
            comment = "";
        }

        public Program(string name, string isAP, DateTime entryDate, string needCode, string participationCode, string comment)
        {
            this.name = name;
            this.isAP = isAP;
            this.entryDate = entryDate;
            this.needCode = needCode;
            this.participationCode = participationCode;
            this.comment = comment;
        }

        public string name { get; set; }
        public string isAP { get; set; }
        public DateTime entryDate { get; set; }
        public string needCode { get; set; }
        public string participationCode { get; set; }
        public string comment { get; set; }

    }
}