using CryptoSearchData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

namespace CryptoCurrencyViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string API_URL_GET = "https://api.coincap.io/v2/assets?limit=10";
        public MainWindow()
        {
            InitializeComponent();
            LoadDataAsync();
        }
        private async void LoadDataAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(API_URL_GET);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var data = CryptoData.FromJson(json);
                        cryptoListView.ItemsSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve data from API.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CryptoInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (cryptoListView.SelectedItem != null)
            {
                Data selectedData = (Data)cryptoListView.SelectedItem;
                Data selectedCrypto = new Data
                {
                    Id = selectedData.Id,
                    Rank = selectedData.Rank,
                    Symbol = selectedData.Symbol,
                    Name = selectedData.Name,
                    Supply = selectedData.Supply,
                    MaxSupply = selectedData.MaxSupply,
                    MarketCap = selectedData.MarketCap,
                    VolumeUsd24Hr = selectedData.VolumeUsd24Hr,
                    Price = selectedData.Price,
                    ChangePercent = selectedData.ChangePercent,
                    Vwap24Hr = selectedData.Vwap24Hr,
                    Explorer = selectedData.Explorer
                };
                CryptoInfoWindow cryptoInfoWindow = new CryptoInfoWindow(selectedCrypto);
                cryptoInfoWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a cryptocurrency from the list.");
            }
        }
        async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchTerm = searchTextBox.Text.ToLower();
                using var client = new HttpClient();
                var response = await client.GetAsync($"https://api.coincap.io/v2/assets/{searchTerm}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var searchedData = JsonConvert.DeserializeObject<SearchedData>(json);
                    cryptoListView.ItemsSource = new List<Data> { searchedData.Data };
                }
                else
                {
                    MessageBox.Show("There is not any cryptocurrency named like that");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


    }
}
