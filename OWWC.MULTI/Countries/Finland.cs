namespace OWWC.MULTI.Countries
{
    public class Finland
    {
        public static int ID { get; set; } = 7;
        public static string nameOfCountry { get; set; } = "Finland";
        public static bool passedGroupStage { get; set; } = true;
        public static string abbreviation { get; set; } = "FI";
        public static string flagLocation { get; set; } = "finishFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "finishFlag.png";
        }
    }
}