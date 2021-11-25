namespace LT.DigitalOffice.AchievementService.Models.Dto.Configurations
{
  public record MemoryCacheConfig
  {
    public const string SectionName = "MemoryCache";

    public double CacheLiveInMinutes { get; set; }
  }
}
