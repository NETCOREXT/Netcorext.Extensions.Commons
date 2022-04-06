using System.Text;
using System.Text.RegularExpressions;

namespace Netcorext.Extensions.Commons;

public static class StringExtensions
{
    #region Encoding

    public static byte[] ToUtf8Bytes(this string source)
    {
        return Encoding.UTF8.GetBytes(source);
    }

    #endregion

    #region Convert

    public static string? ToLowerCamelCase(this string source)
    {
        if (string.IsNullOrWhiteSpace(source)) return null;

        if (source.Length == 1) return source.ToLower();

        if (char.IsUpper(source[0])) return char.ToLower(source[0]) + source[1..];

        return source;
    }

    public static string? ToSnakeCase(this string source)
    {
        if (string.IsNullOrWhiteSpace(source)) return null;

        return Regex.Replace(source, "(?<!_|\\b)([A-Z])", "_$1", RegexOptions.Compiled)
                    .ToLower();
    }

    #endregion

    #region Capture

    public static string? Left(this string source, int length)
    {
        if (string.IsNullOrWhiteSpace(source)) return null;

        return source.Length <= length
                   ? source
                   : source[..length];
    }

    public static string? Right(this string source, int length)
    {
        if (string.IsNullOrWhiteSpace(source)) return null;

        return source.Length - length <= 0
                   ? source
                   : source.Substring(source.Length - length, length);
    }

    #endregion

}