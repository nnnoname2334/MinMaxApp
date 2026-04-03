using System;
using System.Windows;

namespace MinMaxApp
{
    public partial class MainWindow : Window
    {
        private readonly MathLogic _mathLogic;

        public MainWindow()
        {
            InitializeComponent();
            _mathLogic = new MathLogic();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Проверка корректности ввода
            if (double.TryParse(TxtNum1.Text, out double a) &&
                double.TryParse(TxtNum2.Text, out double b) &&
                double.TryParse(TxtNum3.Text, out double c))
            {
                
                bool isMax = RbMax.IsChecked == true;

                
                double result = _mathLogic.Calculate(a, b, c, isMax);

                // Вывод результата
                TxtResult.Text = $"Результат = {result}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные вещественные числа.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}