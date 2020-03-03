namespace OWWC.MULTI.Countries
{
    public class Germany 
    {
        public static int ID { get; set; } = 9;
        public static string nameOfCountry { get; set; } = "Germany";
        public static bool passedGroupStage { get; set; } = false;
        public static string abbreviation { get; set; } = "DE";
        public static string flagLocation { get; set; } = "germanFlag.png";
        public static string GroupStage { get; set; } = "Los Angeles";
        public static int groupStageID { get; set; } = 2;
        public static GroupStage groupstage = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 8, 19);
        public static string GetFlag()
        {
            return "germanFlag.png";
        }
        
    }
}
