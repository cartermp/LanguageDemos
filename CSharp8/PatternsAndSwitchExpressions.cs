using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{ 
    public static class Patterns
    {
        /// <summary>
        /// Switch expression - take an enum and pattern match over it. All as an expression!
        /// </summary>
        public static RGBColor FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _ => throw new ArgumentException("invalid enum value", nameof(colorBand)),
            };

        /// <summary>
        /// Tuple patterns - pattern match on a tuple!
        /// </summary>
        public static string RockPaperScissors(string first, string second) =>
            (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };

        /// <summary>
        /// Property patterns - introspect an object on the fly!
        /// </summary>
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.75M,
                { State: "MI" } => salePrice * 0.05M,
                // other cases removed for brevity...
                _ => 0M
            };

        /// <summary>
        /// Positional patterns - pattern match over a deconstructed type!
        /// </summary>
        public static Quadrant GetQuadrant(Point point) => 
            point switch
            {
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,
                _ => Quadrant.Unknown
            };
    }

    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }

    public struct RGBColor
    {
        public int R { get; }
        public int G { get; }
        public int B { get; }

        public RGBColor(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    public struct Address
    {
        public string State { get; set; }
    }

    public enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four
    }
}
