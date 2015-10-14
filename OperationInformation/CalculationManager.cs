using System;
using System.Security.Cryptography.X509Certificates;

namespace OperationInformation
{
    public class CalculationManager
    {
        /// <summary>
        ///     Calculation will be made for given operation(
        /// </summary>
        public delegate string CalculationHandler(float x, float y);

        public static CalculationHandler GetOperation(Operations op)
        {
            switch (op)
            {
                case Operations.Addition:
                    return (x, y) => x + y + "";
                case Operations.Division:
                    return (x, y) =>
                    {
                        if (x.Equals(0))
                            return "U cant divide by zero!";

                        return x/y + "";
                    };
                case Operations.Multiplication:
                    return (x, y) => x*y + "";
                case Operations.Substraction:
                    return (x, y) => x - y + "";
                case Operations.Sqrt:
                    return (x, y) => Math.Sqrt(x) + "";
                case Operations.Mod:
                    return (x, y) => x%y + "";
            }
            return null;
        }
    }
}
