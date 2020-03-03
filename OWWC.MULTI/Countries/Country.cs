using OWWC.MULTI.Countries;

namespace OWWC.MULTI
{
    public class Country
    {
        public int ID { get; }
        public string NameOfCountry { get; }
        public bool PassedGroupStage { get; }
        public string Abbreviation { get; }
        public string FlagLocation { get; }
        public int GroupStageID { get; }
        public GroupStage Groupstage { get; }
        public string[] Score { get; }
        public Country(int id, string nameOfCountry, bool passedGroupStage, string abbreviation, string flagLocation, int groupStageID, GroupStage groupstage, string[] score)
        {
            ID = id;
            NameOfCountry = nameOfCountry;
            PassedGroupStage = passedGroupStage;
            Abbreviation = abbreviation;
            FlagLocation = flagLocation;
            GroupStageID = groupStageID;
            Groupstage = groupstage;
            Score = score;
        }
        public string GetFlag()
        {
            return FlagLocation;
        }
    }
}
