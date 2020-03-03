namespace OWWC.MULTI.Countries
{
    public class France 
    {
        public static int ID { get; set; } = 8;
        public static string nameOfCountry { get; set; } = "France";
        public static bool passedGroupStage { get; set; } = false;
        public static string abbreviation { get; set; } = "FR";
        public static string flagLocation { get; set; } = "franceFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "franceFlag.png";
        }
       
    }
}
