﻿using System.Numerics;

namespace Doubles
{
    public struct Double3
    {
        public static readonly Double3 One = new()
        {
            X = 1,
            Y = 1,
            Z = 1
        };

        public double X;
        public double Y;
        public double Z;

        public static implicit operator Double3(Vector3 value)
        {
            return new Double3
            {
                X = value.X,
                Y = value.Y,
                Z = value.Z
            };
        }

        public static Double3 Lerp(Double3 a, Double3 b, float t)
        {
            return new Double3
            {
                X = Lerp(a.X, b.X, t),
                Y = Lerp(a.Y, b.Y, t),
                Z = Lerp(a.Z, b.Z, t)
            };
        }

        private static double Lerp(double a, double b, double t)
        {
            return a * (1 - t) + b * t;
        }

        public static Double3 operator +(Double3 a, Double3 b)
        {
            return new Double3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static Double3 operator -(Double3 a, Vector3 b)
        {
            return new Double3
            {
                X = a.X - b.X,
                Y = a.Y - b.Y,
                Z = a.Z - b.Z
            };
        }

        public static Double3 operator *(Double3 a, double b)
        {
            return new Double3
            {
                X = a.X * b,
                Y = a.Y * b,
                Z = a.Z * b
            };
        }

        public static Double3 operator *(double a, Double3 b)
        {
            return new Double3
            {
                X = a * b.X,
                Y = a * b.Y,
                Z = a * b.Z
            };
        }
    }
}