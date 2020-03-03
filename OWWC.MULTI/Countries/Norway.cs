namespace OWWC.MULTI.Countries
{
    public class Norway   
    {
        public static int ID { get; set; } = 14;
        public static string nameOfCountry { get; set; } = "Norway";
        public static bool passedGroupStage { get; set; } = false;
        public static string abbreviation { get; set; } = "NO";
        public static string flagLocation { get; set; } = "norwayFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "norwayFlag.png";
        }
       
    }
}
