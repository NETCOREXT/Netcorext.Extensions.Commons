namespace Netcorext.Extensions.Commons;

public static class MathExtensions
{
    public static long Fact(int n) => n < 1 ? 1 : n * Fact(n - 1);
    public static long C(int n, int m) => Fact(n) / Fact(n - m) / Fact(m);
    public static long H(int n, int m) => Fact(n + m - 1) / Fact(n - 1) / Fact(m);
    public static long P(int n, int m) => Fact(n) / Fact(n - m);

    public static double GaussianNumber(int min, int max)
    {
        var random = new Random();
        var mean = (min + max) / 2.0;
        var variance = (max - min) / 6.0;

        double num;
        do
        {
            num = GenerateGaussianRandom(random, mean, variance);
        }
        while (num < min || num > max);

        return num;
    }

    public static double GenerateGaussianRandom(Random random, double mean, double variance)
    {
        var u1 = 1.0 - random.NextDouble(); // uniform(0,1] random doubles
        var u2 = 1.0 - random.NextDouble();
        var randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // random normal(0,1)
        var randNormal = mean + variance * randStdNormal;                                  // random normal(mean,variance)
        return randNormal;
    }
}
