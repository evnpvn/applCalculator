using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();

            acButton.Click += AcButton_Click;
            posnegButton.Click += PosnegButton_Click;
            percentButton.Click += PercentButton_Click;
            equalsButton.Click += EqualsButton_Click;
            decimalButton.Click += DecimalButton_Click;
            KeyDown += Window_KeyDown;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //if a key is pressed on the keyboard that is a number key (including the decimal button) add that value to the label

            //if 1 character then replace and add
            //if 1 character and zero then do nothing

            switch (e.Key)
            {
                case Key.D0:
                    if (resultLabel.Content.ToString() != "0")
                    {
                        resultLabel.Content += "0";
                    }
                    break;
                case Key.NumPad0:
                    if (resultLabel.Content.ToString() != "0")
                    {
                        resultLabel.Content += "0";
                    }
                    break;

                case Key.D1:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "1";
                    }
                    else
                    {
                        resultLabel.Content += "1";
                    }
                    break;
                case Key.NumPad1:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "1";
                    }
                    else
                    {
                        resultLabel.Content += "1";
                    }
                    break;

                case Key.D2:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "2";
                    }
                    else
                    {
                        resultLabel.Content += "2";
                    }
                    break;
                case Key.NumPad2:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "2";
                    }
                    else
                    {
                        resultLabel.Content += "2";
                    }
                    break;

                case Key.D3:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "3";
                    }
                    else
                    {
                        resultLabel.Content += "3";
                    }
                    break;
                case Key.NumPad3:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "3";
                    }
                    else
                    {
                        resultLabel.Content += "3";
                    }
                    break;

                case Key.D4:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "4";
                    }
                    else
                    {
                        resultLabel.Content += "4";
                    }
                    break;
                case Key.NumPad4:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "4";
                    }
                    else
                    {
                        resultLabel.Content += "4";
                    }
                    break;

                case Key.D5:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "5";
                    }
                    else
                    {
                        resultLabel.Content += "5";
                    }
                    break;
                case Key.NumPad5:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "5";
                    }
                    else
                    {
                        resultLabel.Content += "5";
                    }
                    break;

                case Key.D6:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "6";
                    }
                    else
                    {
                        resultLabel.Content += "6";
                    }
                    break;
                case Key.NumPad6:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "6";
                    }
                    else
                    {
                        resultLabel.Content += "6";
                    }
                    break;

                case Key.D7:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "7";
                    }
                    else
                    {
                        resultLabel.Content += "7";
                    }
                    break;
                case Key.NumPad7:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "7";
                    }
                    else
                    {
                        resultLabel.Content += "7";
                    }
                    break;

                case Key.D8:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "8";
                    }
                    else
                    {
                        resultLabel.Content += "8";
                    }
                    break;
                case Key.NumPad8:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "8";
                    }
                    else
                    {
                        resultLabel.Content += "8";
                    }
                    break;

                case Key.D9:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "9";
                    }
                    else
                    {
                        resultLabel.Content += "9";
                    }
                    break;
                case Key.NumPad9:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "9";
                    }
                    else
                    {
                        resultLabel.Content += "9";
                    }
                    break;

                case Key.Decimal:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "0.";
                    }
                    else
                    {
                        resultLabel.Content += ".";
                    }
                    break;

                case Key.OemPeriod:
                    if (resultLabel.Content.ToString() == "0")
                    {
                        resultLabel.Content = "0.";
                    }
                    else if (!resultLabel.Content.ToString().Contains('.'))
                    {
                        resultLabel.Content += ".";
                    }
                    break;
            }
        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (!resultLabel.Content.ToString().Contains('.'))
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out double newNumber))
            {
                switch(selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = SimpleMath.Subtract(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = result.ToString();
            }
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber /= 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void PosnegButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber *= -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == multiplyButton)  selectedOperator = SelectedOperator.Multiplication; 
            if (sender == divideButton)    selectedOperator = SelectedOperator.Division; 
            if (sender == minusButton)     selectedOperator = SelectedOperator.Subtraction; 
            if (sender == plusButton)      selectedOperator = SelectedOperator.Addition; 
        }
           

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == zeroButton)  { selectedValue = 0; }
            if (sender == oneButton)   { selectedValue = 1; }
            if (sender == twoButton)   { selectedValue = 2; }
            if (sender == threeButton) { selectedValue = 3; }
            if (sender == fourButton)  { selectedValue = 4; }
            if (sender == fiveButton)  { selectedValue = 5; }
            if (sender == sixButton)   { selectedValue = 6; }
            if (sender == sevenButton) { selectedValue = 7; }
            if (sender == eightButton) { selectedValue = 8; }
            if (sender == nineButton)  { selectedValue = 9; }

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public class SimpleMath
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            if(number2 == 0)
            {
                MessageBox.Show("Cannot divide by 0", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return 0;
            }

            return number1 / number2;
        }
    }
}
