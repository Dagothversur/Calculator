namespace Calculator
{
    internal static class Calculations
    {
        public static string Addition(float x, float y)
        {
            return x + y + "";
        }

        public static string Substraction(float x, float y)
        {
            return x - y + "";
        }

        public static string Multiplication(float x, float y)
        {
            return x*y + "";
        }

        public static string Division(float x, float y)
        {
            if (x.Equals(0.0F))
                return "U can't divide by zero!";

            return x/y + "";
        }
    }
}
