namespace OWWC.MULTI.Countries
{
    public class Thailand 
    {
        public static int ID { get; set; } = 22;
        public static string nameOfCountry { get; set; } = "Thailand";
        public static bool passedGroupStage { get; set; } = false;
        public static string abbreviation { get; set; } = "TH";
        public static string flagLocation { get; set; } = "thaiFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "thaiFlag.png";
        }
       
    }
}
