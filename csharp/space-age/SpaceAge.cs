using System;

public class SpaceAge
{
    private readonly double _earthAge;

    public SpaceAge(int seconds) => _earthAge = seconds / (86400 * 365.25);

    public double OnEarth() => _earthAge;

    public double OnMercury() => _earthAge / 0.2408467;

    public double OnVenus() => _earthAge / 0.61519726;

    public double OnMars() => _earthAge / 1.8808158;

    public double OnJupiter() => _earthAge / 11.862615;

    public double OnSaturn() => _earthAge / 29.447498;

    public double OnUranus() => _earthAge / 84.016846;

    public double OnNeptune() => _earthAge / 164.79132;
}