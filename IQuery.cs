using System;

namespace rowboat
{
    public interface IQuery
    {
        string name {get; set; }
        string check { get; set; }
        int sidCheckRow { get; set; }
        int sidCheckCol { get; set; }
        int cidCheckRow { get; set; }
        int cidCheckCol { get; set; }
        int sidFieldRow { get; set; }
        int sidFieldCol { get; set; }
        int cidFieldRow { get; set; }
        int cidFieldCol { get; set; }
        int[] route { get; set; }
        string[] scrape();

    }
}