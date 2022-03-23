using System.Text.RegularExpressions;

namespace Netcorext.Extensions.Commons;

public static class ValidateExtensions
{
    #region IsEmpty

    public static bool IsEmpty(this string? source) => string.IsNullOrWhiteSpace(source);
    public static bool IsEmpty(this int source) => source == 0;
    public static bool IsEmpty(this int? source) => source is null or 0;
    public static bool IsEmpty(this long source) => source == 0;
    public static bool IsEmpty(this long? source) => source is null or 0;
    public static bool IsEmpty(this double source) => source == 0;
    public static bool IsEmpty(this double? source) => source is null or 0;
    public static bool IsEmpty(this float source) => source == 0;
    public static bool IsEmpty(this float? source) => source is null or 0;
    public static bool IsEmpty(this decimal source) => source == 0;
    public static bool IsEmpty(this decimal? source) => source is null or 0;
    public static bool IsEmpty(this DateTime source) => source == default;
    public static bool IsEmpty(this DateTime? source) => source is null  || source == DateTime.MinValue;
    public static bool IsEmpty(this DateTimeOffset source) => source == default;
    public static bool IsEmpty(this DateTimeOffset? source) => source is null || source == DateTimeOffset.MinValue;
    public static bool IsEmpty(this TimeSpan source) => source.TotalMilliseconds == 0;
    public static bool IsEmpty(this TimeSpan? source) => source is null || source.Value.TotalMilliseconds == 0;

    #endregion

    #region IsNull

    public static bool IsNull(this string? source) => source == null;
    public static bool IsNull(this int? source) => source == null;
    public static bool IsNull(this long? source) => source == null;
    public static bool IsNull(this double? source) => source == null;
    public static bool IsNull(this float? source) => source == null;
    public static bool IsNull(this decimal? source) => source == null;
    public static bool IsNull(this DateTime? source) => source == null;
    public static bool IsNull(this DateTimeOffset? source) => source == null;
    public static bool IsNull(this TimeSpan? source) => source == null;
    public static bool IsNull(this object? source) => source == null;

    #endregion

    public static bool IsAlphaNumeric(this string source) => Regex.IsMatch(source, @"^[A-Za-z0-9]+$");
    public static bool IsEmail(this string source) => Regex.IsMatch(source, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
    public static bool IsPhoneNumber(this string source) => Regex.IsMatch(source, @"^[\d*+#]{1,20}$");
    public static bool IsNumeric(this string source) => decimal.TryParse(source, out _);
    public static bool IsDate(this string source) => DateTimeOffset.TryParse(source, out _);
    public static bool IsTime(this string source) => TimeSpan.TryParse(source, out _);
}