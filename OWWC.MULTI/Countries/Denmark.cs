namespace OWWC.MULTI.Countries
{
    public class Denmark
    {
        public static int ID { get; set; } = 6;
        public static string nameOfCountry { get; set; } = "Denmark";
        public static bool passedGroupStage { get; set; } = false;
        public static string abbreviation { get; set; } = "DK";
        public static string flagLocation { get; set; } = "denmarkFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "denmarkFlag.png";
        }

    }
}
