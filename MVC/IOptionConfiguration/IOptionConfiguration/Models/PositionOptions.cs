namespace IOptionConfiguration.Models
{
    public class PositionOptions
    {
        //private readonly ILogger _logger;
        //public PositionOptions(ILogger logger)
        //{
        //    _logger = logger;
        //    _logger.LogWarning("PositionOptions -> Model Error");
        //}


        public const string Position = "Position";

        public string Title { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
    }
}