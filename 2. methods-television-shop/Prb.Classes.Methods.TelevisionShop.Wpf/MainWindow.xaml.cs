using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using Prb.Classes.Methods.TelevisionShop.Core;

namespace Prb.Classes.Methods.TelevisionShop.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> brands = new List<string>();
        List<char> energyLabels = new List<char>();

        public MainWindow()
        {
            InitializeComponent();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateEnergyBrands();
            CreateEnergyLabels();

            cmbBrands.ItemsSource = brands;
            cmbEnergyLabel.ItemsSource = energyLabels;
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            string brand = cmbBrands.SelectedItem.ToString();
            int diagonal = int.Parse(txtScreenSize.Text);
            char energyLabel = (char)cmbEnergyLabel.SelectedItem;

            Television newTelevision = new Television(brand, diagonal, energyLabel);

            lstTelevisions.Items.Add(newTelevision);


            tbkLog.Text = LogData(brand, diagonal, energyLabel);
        }

        private string LogData(string brand, int diagonal, char energyLabel)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nieuwe TV werd aangemaakt met volgende kenmerken:");
            sb.AppendLine($"Merknaam: {brand}");
            sb.AppendLine($"Schermbreedte: {diagonal}\"");
            sb.AppendLine($"Energielabel: {energyLabel}");

            return sb.ToString();

        }

        private void CreateEnergyBrands()
        {
            brands.Add("Samsung");
            brands.Add("Philips");
            brands.Add("Sony");
            brands.Add("LG");
        }

        private void CreateEnergyLabels() 
        {
            energyLabels.Add('A');
            energyLabels.Add('B');
            energyLabels.Add('C');
            energyLabels.Add('D');
            energyLabels.Add('E');
            energyLabels.Add('F');
        }

    }
}
