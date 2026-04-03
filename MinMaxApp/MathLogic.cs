using System;

namespace MinMaxApp
{
    public class MathLogic
    {
        // Метод для нахождения нужного значения
        public double Calculate(double a, double b, double c, bool isFindMax)
        {
            if (isFindMax)
            {
                return Math.Max(a, Math.Max(b, c));
            }
            else
            {
                return Math.Min(a, Math.Min(b, c));
            }
        }
    }
}