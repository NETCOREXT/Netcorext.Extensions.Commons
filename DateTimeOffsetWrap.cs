namespace System;

public static class DateTimeOffsetWrap
{
    public static DateTimeOffset TaipeiNow => DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8));
    public static DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    public static DateTimeOffset Now => DateTimeOffset.Now;
    public static DateTimeOffset ToTaipeiTime(this DateTimeOffset dateTimeOffset) => dateTimeOffset.ToUniversalTime().ToOffset(TimeSpan.FromHours(8));
}