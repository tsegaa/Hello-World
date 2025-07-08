namespace MathLib
{
    public static class MathOperations
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double? Divide(double a, double b)
        {
            return b == 0 ? (double?)null : a / b;
        }
    }
}
