using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string literInput;
        string typeInput;
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            numberSlider.Text = slider.Value.ToString("0.0");

            literInput = numberSlider.Text;
            numberSlider.Text += " liter";
            var input = Convert.ToDouble(literInput);
            if (typeInput != null)
            {
                switch (typeInput)
                {
                    case "Pertamax Turbo":
                        priceTextBlock.Text = $"Pertamax Turbo : Rp. {input * 17_900}";
                        
                        break;
                    case "Pertamax":
                        priceTextBlock.Text = $"Pertamax Turbo : Rp. {input * 12_500}";

                        break;
                    case "Pertalite":
                        priceTextBlock.Text = $"Pertamax Turbo : Rp. {input * 7_650}";

                        break;
                    case "Pertamina Dex":
                        priceTextBlock.Text = $"Pertamax Turbo : Rp. {input * 18_900}";

                        break;
                    case "Dexlite":
                        priceTextBlock.Text = $"Pertamax Turbo : Rp. {input * 17_800}";

                        break;

                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                //priceTextBlock.Text = radioButton.Content.ToString();
                typeInput = radioButton.Content.ToString();
            }
        }
    }
}
