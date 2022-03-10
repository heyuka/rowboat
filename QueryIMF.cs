using System;

namespace rowboat
{
    class QueryIMF : IQuery
    {
        public QueryIMF(string name, string check, int sidCheckRow, int sidCheckCol, int cidCheckRow, int cidCheckCol, int sidFieldRow, int sidFieldCol, int cidFieldRow, int cidFieldCol, int[] route)
        {
            this.name = name;
            this.check = check;
            this.sidCheckRow = sidCheckRow;
            this.sidCheckCol = sidCheckCol;
            this.cidCheckRow = cidCheckRow;
            this.cidCheckCol = cidCheckCol;
            this.sidFieldRow = sidFieldRow;
            this.sidFieldCol = sidFieldCol;
            this.cidFieldRow = cidFieldRow;
            this.cidFieldCol = cidFieldCol;
            this.route = route;
        }

        public string name {get; set; }
        public string check { get; set; }
        public int sidCheckRow { get; set; }
        public int sidCheckCol { get; set; }
        public int cidCheckRow { get; set; }
        public int cidCheckCol { get; set; }
        public int sidFieldRow { get; set; }
        public int sidFieldCol { get; set; }
        public int cidFieldRow { get; set; }
        public int cidFieldCol { get; set; }
        public int[] route { get; set; }
        public string[] scrape()
        {
            return new string[]{"not", "yet", "implemented"};
        }

        
    }
}