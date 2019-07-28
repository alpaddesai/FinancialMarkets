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
using System.Windows.Shapes;

namespace FinancialMarkets
{
    /// <summary>
    /// Interaction logic for PortfolioAnalysis.xaml
    /// </summary>
    public partial class PortfolioAnalysis : Window
    {
        public PortfolioAnalysis()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Portfolio_Performance_Click(object sender, RoutedEventArgs e)
        {
            StockMarketAnalysis StockMarketAnalysisObject = new StockMarketAnalysis();
            StockMarketAnalysisObject.Show();
        }

 

        private void Companies_Click(object sender, RoutedEventArgs e)
        {
            Companies CompaniesObject = new Companies();
            CompaniesObject.Show();
        }

        private void WeekOne_Click(object sender, RoutedEventArgs e)
        {
            WeekOne WeekOneObject = new WeekOne();
            WeekOneObject.Show();
        }

        private void WeekTwo_Click(object sender, RoutedEventArgs e)
        {
            WeekTwo WeekTwoObject = new WeekTwo();
            WeekTwoObject.Show();
        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

 
        private void Forecast_Companies_Click(object sender, RoutedEventArgs e)
        {
            Forecast_Companies Forecast_CompaniesObject = new Forecast_Companies();
            Forecast_CompaniesObject.Show();

        }
    }
}
