using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace PSM.Barcode
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        ObservableCollection<string> scanList = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            ScanListView.ItemsSource = scanList;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            // Add scan to the list
            scanList.Add($"Scan {count}");
        }
    }
}
