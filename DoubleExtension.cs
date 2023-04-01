namespace Doubles
{
    public static class DoubleExtension
    {
        public static double SqrMagnitude(this Double3 value)
        {
            return value.X * value.X + value.Y * value.Y + value.Z * value.Z;
        }
    }
}