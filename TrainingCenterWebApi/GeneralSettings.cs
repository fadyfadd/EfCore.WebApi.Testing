namespace TrainingCenterWebApi
{
    public class GeneralSettings
    {
        public const String sectionName = "GeneralSettings";
        public required String ConnectionString { get; set; }

        public required String CorsAllowedOrigins { get; set; }
    }
}
