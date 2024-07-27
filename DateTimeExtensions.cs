namespace Netcorext.Extensions.Commons;

public static class DateTimeExtensions
{
    public const string DEFAULT_TAIPEI_TIME_ZONE = "Asia/Taipei";
    public static readonly TimeZoneInfo TaipeiTimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone(DEFAULT_TAIPEI_TIME_ZONE, TimeSpan.FromHours(8), DEFAULT_TAIPEI_TIME_ZONE, DEFAULT_TAIPEI_TIME_ZONE);
    public static DateTimeOffset TaipeiNow => TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, TaipeiTimeZoneInfo);
    public static DateTimeOffset ToTaipeiTime(this DateTimeOffset dateTimeOffset) => TimeZoneInfo.ConvertTime(dateTimeOffset, TaipeiTimeZoneInfo);
    public static DateTimeOffset BeginOfDay(this DateTimeOffset dateTimeOffset) => new DateTimeOffset(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 0, 0, 0, 0, dateTimeOffset.Offset);
    public static DateTimeOffset EndOfDay(this DateTimeOffset dateTimeOffset) => new DateTimeOffset(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 23, 59, 59, 999, dateTimeOffset.Offset);
    public static bool IsAm(this DateTimeOffset dateTimeOffset) => dateTimeOffset.Hour < 12;
    public static bool IsPm(this DateTimeOffset dateTimeOffset) => dateTimeOffset.Hour >= 12;

    public static bool IsBetween(this DateTimeOffset dateTimeOffset, DateTimeOffset d1, DateTimeOffset d2, bool inclusive = true)
    {
        var start = d1 <= d2 ? d1 : d2;
        var end = d1 > d2 ? d1 : d2;

        return inclusive
            ? dateTimeOffset >= start && dateTimeOffset <= end
            : dateTimeOffset > start && dateTimeOffset < end;
    }

}
