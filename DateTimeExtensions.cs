namespace Netcorext.Extensions.Commons;

public static class DateTimeExtensions
{
    public const string DEFAULT_TAIPEI_TIME_ZONE = "Asia/Taipei";
    public static readonly TimeZoneInfo TaipeiTimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(DEFAULT_TAIPEI_TIME_ZONE, TimeSpan.FromHours(8), DEFAULT_TAIPEI_TIME_ZONE, DEFAULT_TAIPEI_TIME_ZONE);
    public static DateTimeOffset TaipeiNow => TimeZoneInfo.ConvertTime(DateTime.UtcNow, TaipeiTimeZoneInfo);
    public static DateTimeOffset ToTaipeiTime(this DateTimeOffset dateTimeOffset) => TimeZoneInfo.ConvertTime(dateTimeOffset, TaipeiTimeZoneInfo);
    public static DateTimeOffset BeginOfDay(this DateTimeOffset dateTimeOffset) => new DateTimeOffset(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 0, 0, 0, 0, dateTimeOffset.Offset);
    public static DateTimeOffset EndOfDay(this DateTimeOffset dateTimeOffset) => new DateTimeOffset(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 23, 59, 59, 999, dateTimeOffset.Offset);
}
