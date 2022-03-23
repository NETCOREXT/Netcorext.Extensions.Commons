namespace Netcorext.Extensions.Commons;

public static class MathExtensions
{
    public static long Fact(int n) => n < 1 ? 1 : n * Fact(n - 1);
    public static long C(int n, int m) => Fact(n) / Fact(n - m) / Fact(m);
    public static long H(int n, int m) => Fact(n + m - 1) / Fact(n - 1) / Fact(m);
    public static long P(int n, int m) => Fact(n) / Fact(n - m);
}