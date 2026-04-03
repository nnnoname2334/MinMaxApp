using System;

namespace MinMaxApp
{
    /// <summary>
    /// Класс, содержащий математическую логику приложения.
    /// </summary>
    public class MathLogic
    {
        /// <summary>
        /// Метод для нахождения нужного значения (максимума или минимума).
        /// </summary>
        /// <param name="a">Первое вещественное число.</param>
        /// <param name="b">Второе вещественное число.</param>
        /// <param name="c">Третье вещественное число.</param>
        /// <param name="isFindMax">Флаг: true для поиска максимума, false для минимума.</param>
        /// <returns>Возвращает найденное экстремальное значение.</returns>
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