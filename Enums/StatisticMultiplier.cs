using System;

public enum StatisticMultiplier
{
    Low,
    Medium, 
    High
}

public static class StatisticMultiplierExtensions
{
    public static double GetMultiplierValue(this StatisticMultiplier multiplier)
    {
        switch (multiplier)
        {
            case StatisticMultiplier.Low:
                return 0.75;
            case StatisticMultiplier.Medium:
                return 1.0;
            case StatisticMultiplier.High:
                return 1.25;
            default:
                throw new ArgumentException("Invalid StatisticMultiplier value");
        }
    }
}