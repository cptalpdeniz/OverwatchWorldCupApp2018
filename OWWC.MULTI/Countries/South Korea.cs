namespace OWWC.MULTI.Countries
{
    public class SouthKorea 
    {
        public static int ID { get; set; } = 17;
        public static string nameOfCountry { get; set; } = "South Korea";
        public static bool passedGroupStage { get; set; } = true;
        public static string abbreviation { get; set; } = "KR";
        public static string flagLocation { get; set; } = "skFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "skFlag.png";
        }
       
    }
}
