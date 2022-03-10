using System;

namespace rowboat
{
    class History
    {
        public History()
        {
            this.unitCode = "";
            this.reasonCode = "";
            this.dateAssignment = DateTime.MinValue;
            this.typeInstitution = "";
            this.numCID = "";
        }

        public History(string unitCode, string reasonCode, DateTime dateAssignment, string typeInstitution, string numCID)
        {
            this.unitCode = unitCode;
            this.reasonCode = reasonCode;
            this.dateAssignment = dateAssignment;
            this.typeInstitution = typeInstitution;
            this.numCID = numCID;
        }

        public string unitCode { get; set; }
        public string reasonCode { get; set; }
        public DateTime dateAssignment { get; set; }
        public string typeInstitution { get; set; }
        public string numCID { get; set; }
    }
}