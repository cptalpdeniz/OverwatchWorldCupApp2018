using System;
namespace OWWC.MULTI.Countries
{
    public class GroupStage
    {
        public string name;
        public int ID;
        public DateTime StartDate;
        public DateTime EndDate;
        public GroupStage(string nameT, int IDD, int y1, int m1, int d1, int y2, int m2, int d2)
        {
            name = nameT;
            ID = IDD;
            StartDate = new DateTime(y1, m1, d1);
            EndDate = new DateTime(y2, m2, d2);
        }
    }
}
