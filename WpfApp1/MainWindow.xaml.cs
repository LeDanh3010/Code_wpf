using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
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
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The message is: {this.DescriptionText.Text}");
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            this.checkBoxWeld.IsChecked = this.checkBoxAssembly.IsChecked = this.checkBoxLaser.IsChecked = this.checkBoxPlasma.IsChecked = this.checkBoxPurchase.IsChecked = false;
            this.lengthBox.Text = "";
           
        }

        private void Dropdown_Click(object sender, SelectionChangedEventArgs e)
        {
            ComboBox? combo = sender as ComboBox;
            ComboBoxItem? comboItem = combo?.SelectedItem as ComboBoxItem;
            if (comboItem != null)
            {
                this.lengthBox.Text = comboItem.Content.ToString();
            }
        }



        private void checkedClick(object sender, RoutedEventArgs e)
        {

            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                this.lengthBox.Text += checkBox.Content.ToString();
                //MessageBox.Show($"Event: {e.Source}\n");
                //MessageBox.Show($"Event: {e.RoutedEvent}\n");
            }
            
        }

        private void changeText(object sender, TextChangedEventArgs e)
        {
            this.supplierName.Text = this.nameMass.Text;
        }

    }

}