namespace Calculator
{
    public static class CalculationManager
    {
        /// <summary>
        ///     Calculation will be made for given operation(
        /// </summary>
        public static string Calculate(float x, float y, Operations operation)
        {
            switch (operation)
            {
                case Operations.Addition:
                    return Calculations.Addition(x, y);
                case Operations.Substraction:
                    return Calculations.Substraction(x, y);
                case Operations.Multiplication:
                    return Calculations.Multiplication(x, y);
                case Operations.Division:
                    return Calculations.Division(x, y);
            }

            return "";
        }
    }
}
