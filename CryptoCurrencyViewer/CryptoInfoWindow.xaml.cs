using CryptoCurrencyViewer;
using CryptoSearchData;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Xml;


namespace CryptoCurrencyViewer
{
    public partial class CryptoInfoWindow : Window
    {
        public CryptoInfoWindow(Data crypto)
        {
            InitializeComponent();

            nameLabel.Content = crypto.Name;
            rankLabel.Content = $"Rank: {crypto.Rank}";
            priceLabel.Content = $"Price: {crypto.Price:C2}$";
            marketCapLabel.Content = $"Market Cap: {crypto.MarketCap:C2}$";
            changePercentLabel.Content = $"Change % (24h): {crypto.ChangePercent:F2}%";
            supplyLabel.Content = $"{crypto.Supply:F2}$";
            maxSupplyLabel.Content = $"{crypto.MaxSupply:F2}$";
            volumeUsd24HrLabel.Content = $"{crypto.VolumeUsd24Hr:C2}$";

            var explorerLink = new Hyperlink();
            explorerLink.NavigateUri = new Uri(crypto.Explorer.ToString());
            explorerLink.Inlines.Add(crypto.Explorer.ToString());

            explorerLabel.Text = $"";
            explorerLabel.Inlines.Add(explorerLink);

            explorerLink.RequestNavigate += (sender, e) =>
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
                e.Handled = true;
            };
        }


        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
